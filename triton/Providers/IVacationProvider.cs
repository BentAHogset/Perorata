using System;
using System.Collections.Generic;
using System.Text;
using triton.Models;

namespace triton.Providers
{
    public interface IVacationProvider
    {
        VacationModel GetModel();
    }
}
