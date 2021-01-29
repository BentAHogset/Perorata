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
                Title = "Sommerferie 2020",
                Comment="Må ta ut 8 uker ferie, selv om jeg kun har 4 tilgjengelig. 4 uker i forskudd!"
            };
            return model;
        }
    }
}
