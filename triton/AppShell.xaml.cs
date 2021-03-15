using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triton.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(main), typeof(main));
            Routing.RegisterRoute(nameof(userprofile), typeof(userprofile));
            
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//vacation");
           //await Navigation.PushAsync(new vacation());
        }
    }
}