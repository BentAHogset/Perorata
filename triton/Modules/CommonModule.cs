using System;
using System.Collections.Generic;
using System.Text;
using triton.Providers;
using triton.Services;

namespace triton.Kernels
{
    public class CommonModule: Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IVacationService>().To<VacationService>();
            Bind<IVacationProvider>().To<VacationProvider>();

        }
    }
}
