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

            var isAuthorized = false;// await restServices.IsAuthorized();
            Console.WriteLine("User authenticated " + isAuthorized);
            if (isAuthorized)
            {
                App.Configs = await restServices.GetConfig();
                Console.WriteLine("Config from db: " + App.Configs.ConfigList.Count());

                var menusMocked = restServices.GetMenuItemsMocked();
                Console.WriteLine("Menu items mocked: " + menusMocked.Count());

                try
                {
                    var menusFromDb = await restServices.GetMenuItems();
                    if (menusFromDb != null)
                    {
                        Console.WriteLine("Menu items from db: " + menusFromDb.Count());
                    }
                    else
                    {
                        Console.WriteLine("Menu items from db: 0");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Menu items from db fails: " + e.Message);
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

            // Hack - should be a toggler
            Device.StartTimer(TimeSpan.FromMilliseconds(500), () => {
                imgProfile.Source = "profile";
                return true;
            });
        }
    }
}