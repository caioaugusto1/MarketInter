﻿using Inter.Core.App.Intefaces;
using Inter.Core.App.ViewModel;
using Inter.Core.Presentation.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Inter.Core.Presentation.Controllers
{
    //[Authorize(Roles = "Admin, Users")]
    public class FileUploadController : Controller
    {
        private readonly ICulturalExchangeFileUploadAppService _culturalExchangeFileUploadAppService;
        private readonly IOptions<AppSettings> _appSetttings;

        public FileUploadController(
            ICulturalExchangeFileUploadAppService culturalExchangeAppService,
            IOptions<AppSettings> appSetttings)
        {
            _culturalExchangeFileUploadAppService = culturalExchangeAppService;
            _appSetttings = appSetttings;
        }

        public IActionResult Index()
        {
            return View();
        }

        private async Task<string> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return null;

            string fileName = Guid.NewGuid().ToString() + ".pdf";

            var pathFolder = _appSetttings.Value.UploadFilePath;

            var pathCombine = Path.Combine(
                pathFolder,
                        fileName);

            if (!Directory.Exists(pathFolder))
                Directory.CreateDirectory(pathFolder);

            using (var stream = new FileStream(pathCombine, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return fileName;
        }

        private void DeleteFile(string fileName)
        {
            var path = Path.Combine(_appSetttings.Value.UploadFilePath,
                       fileName);

            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
        }

        public async Task<IActionResult> Download(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return Content("filename not present");

            var path = Path.Combine(_appSetttings.Value.UploadFilePath, fileName);

            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf");
        }

        public async Task<IActionResult> CulturalExchangeDeleteFile(Guid id, string fileName)
        {
            try
            {
                if (id != Guid.Empty && !string.IsNullOrWhiteSpace(fileName))
                {
                    _culturalExchangeFileUploadAppService.Delete(id);
                    DeleteFile(fileName);

                    return Json(Ok());
                }

                return Json(Conflict());
            }
            catch (Exception ex)
            {
                return Json(BadRequest());
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetModalCulturalExchangeUploadFile(Guid culturalExchangeId)
        {
            CulturalExchangeFileUploadViewModel culturalExchangeFileUploadViewModel = new CulturalExchangeFileUploadViewModel();
            culturalExchangeFileUploadViewModel.CulturalExchangeId = culturalExchangeId;

            return PartialView("~/Views/FileUpload/_partial/_modal_culturalExchange_upload_file.cshtml", culturalExchangeFileUploadViewModel);
        }
        
        [HttpPost]
        public async Task<JsonResult> PostModalCulturalExchangeUploadFile(CulturalExchangeFileUploadViewModel fileUploadViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var fileName = await UploadFile(fileUploadViewModel.File);

                    if (!string.IsNullOrWhiteSpace(fileName))
                    {
                        fileUploadViewModel.FileName = fileName;

                        _culturalExchangeFileUploadAppService.Add(fileUploadViewModel);
                        return Json(Ok());
                    }
                }

                return Json(Conflict());
            }
            catch (Exception ex)
            {
                DeleteFile(fileUploadViewModel.FileName);

                return Json(BadRequest());
            }
        }

    }
}
