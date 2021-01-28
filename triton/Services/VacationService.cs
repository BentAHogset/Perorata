using System;
using System.Collections.Generic;
using System.Text;
using triton.Models;

namespace triton.Services
{
    public class VacationService : IVacationService
    {

        public VacationModel GetVacationModel(int formId)
        {
            var model = new VacationModel
            {
                Title = "Sommerferie 2020"
            };
            return model;
        }
    }
}
