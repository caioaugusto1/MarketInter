﻿using AutoMapper;
using Inter.Core.App.Intefaces;
using Inter.Core.App.ViewModel;
using Inter.Core.Domain.Entities;
using Inter.Core.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Inter.Core.App.Application
{
    public class CollegeTimeAppService : ICollegeTimeAppService
    {
        private readonly IMapper _mapper;
        private readonly ICollegeTimeService _collegeService;

        public CollegeTimeAppService(
            IMapper mapper,
            ICollegeTimeService collegeService)
        {
            _mapper = mapper;
            _collegeService = collegeService;
        }

        public CollegeTimeViewModel Add(CollegeTimeViewModel collegeTimeVM)
        {
            var collegeEntity = _mapper.Map<CollegeTime>(collegeTimeVM);
            return _mapper.Map<CollegeTimeViewModel>(_collegeService.Add(collegeEntity));
        }

        public List<CollegeTimeViewModel> GetAllByCollegeId(int idCollege)
        {
            return _mapper.Map<List<CollegeTimeViewModel>>(_collegeService.GetAll(idCollege));
        }

        public CollegeTimeViewModel GetById(int id)
        {
            return _mapper.Map<CollegeTimeViewModel>(_collegeService.GetById(id));
        }

        public CollegeTimeViewModel Update(CollegeTimeViewModel collegeTimeVM)
        {
            var collegeEntity = _mapper.Map<CollegeTime>(collegeTimeVM);

            return _mapper.Map<CollegeTimeViewModel>(_collegeService.Update(collegeEntity));
        }
    }
}
