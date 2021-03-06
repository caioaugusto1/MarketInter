﻿using AutoMapper;
using Inter.Core.App.Intefaces;
using Inter.Core.App.ViewModel;
using Inter.Core.Domain.Entities;
using Inter.Core.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Inter.Core.App.Application
{
    public class AccomodationAppService : IAccomodationAppService
    {
        private readonly IMapper _mapper;
        private readonly IAccomodationService _accomodationService;

        public AccomodationAppService(IAccomodationService accomodationService, IMapper mapper)
        {
            _accomodationService = accomodationService;
            _mapper = mapper;
        }

        public AccomodationViewModel Add(Guid environmentId, AccomodationViewModel accomodationViewModel)
        {
            accomodationViewModel.EnviromentId = environmentId;
            var accomodation = _mapper.Map<Accomodation>(accomodationViewModel);

            return _mapper.Map<AccomodationViewModel>(_accomodationService.Add(accomodation));
        }

        public AccomodationViewModel GetAccomodationAndCulturalExchangeList(Guid id)
        {
            return _mapper.Map<AccomodationViewModel>(_accomodationService.GetAccomodationAndCulturalExchangeList(id));
        }

        public List<AccomodationViewModel> GetAll(Guid idEnvironment)
        {
            return _mapper.Map<List<AccomodationViewModel>>(_accomodationService.GetAll(idEnvironment));
        }

        public List<AccomodationViewModel> GetAllAvaliable(Guid idEnvironment)
        {
            return _mapper.Map<List<AccomodationViewModel>>(_accomodationService.GetAllAvaliable(idEnvironment));
        }

        public AccomodationViewModel GetById(Guid id)
        {
            return _mapper.Map<AccomodationViewModel>(_accomodationService.GetById(id));
        }

        public AccomodationViewModel Update(AccomodationViewModel accomodationViewModel)
        {
            var accomodation = _mapper.Map<Accomodation>(accomodationViewModel);
            return _mapper.Map<AccomodationViewModel>(_accomodationService.Update(accomodation));
        }
    }
}
