using System;
using System.Collections.Generic;
using System.Text;
using triton.Models;
using triton.Services;

namespace triton.Providers
{
    public class VacationProvider : IVacationProvider
    {
        private IVacationService vacationService;

        public VacationProvider(IVacationService vacationService)
        {
            this.vacationService = vacationService;
        }

        public VacationModel GetModel()
        {
            return vacationService.GetVacationModel(1);
        }
    }
}
