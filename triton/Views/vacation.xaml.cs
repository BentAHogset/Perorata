using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triton.Models;
using triton.Providers;
using triton.Services;
using triton.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vacation : ContentPage
    {

        public vacation()
        {
            InitializeComponent();

            var vacationProvider = App.Kernel.Get<IVacationProvider>();
            BindingContext = new VacationViewModel(vacationProvider);
        }
    }
}