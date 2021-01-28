using System;
using System.Collections.Generic;
using System.Text;
using triton.Models;

namespace triton.Services
{
    public interface IVacationService
    {
        VacationModel GetVacationModel(int formId);
    }
}
