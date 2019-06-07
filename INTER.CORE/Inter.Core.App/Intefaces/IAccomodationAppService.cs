﻿using Inter.Core.App.ViewModel;
using System.Collections.Generic;

namespace Inter.Core.App.Intefaces
{
    public interface IAccomodationAppService
    {
        AccomodationViewModel Add(int environmentId, AccomodationViewModel accomodationViewModel);

        List<AccomodationViewModel> GetAll(int idEnvironment);

        AccomodationViewModel GetById(int id);

        AccomodationViewModel Update(AccomodationViewModel accomodationViewModel);
    }
}
