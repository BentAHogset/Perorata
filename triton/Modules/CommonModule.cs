using System;
using System.Collections.Generic;
using System.Text;
using triton.Providers;
using triton.Rest;
using triton.Services;

namespace triton.Kernels
{
    public class CommonModule: Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IVacationService>().To<VacationService>();
            Bind<IVacationProvider>().To<VacationProvider>();
            Bind<IRestServices>().To<RestServices>();
            Bind<IClientProvider>().To<ClientProvider>();
            Bind<IProfileService>().To<ProfileService>();
            Bind<IProfileProvider>().To<ProfileProvder>();

        }
    }
}
