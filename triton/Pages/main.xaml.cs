using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using triton.Rest;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class main : ContentPage
    {

        public main()
        {
            InitializeComponent();
            GetDataSources();
        }

        private async void GetDataSources()
        {
            var restServices = App.Kernel.Get<IRestServices>();

            var isAuthorized = await restServices.IsAuthorized();
            if (isAuthorized)
            {
                App.Configs = await restServices.GetConfig();
                Console.WriteLine("Config fra DB: " + App.Configs.ConfigList.Count());

                var menusMocked = restServices.GetMenuItemsMocked();
                Console.WriteLine("Menypunkter mocked: " + menusMocked.Count());

                try
                {
                    var menusFromDb = await restServices.GetMenuItems();
                    if (menusFromDb != null)
                    {
                        Console.WriteLine("Menypunkter fra DB: " + menusFromDb.Count());
                    }
                    else
                    {
                        Console.WriteLine("Menypunkter fra DB: 0");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Menypunkter fra DB feil: " + e.Message);
                }
            }
        }

        private void Vacation_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new vacation());
        }

        private void Absence_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new absence());
        }

        private void User_Clicked(object sender, EventArgs e)
        {
            imgProfile.Source = "profile_touched";
            Navigation.PushAsync(new userprofile());
        }
    }
}