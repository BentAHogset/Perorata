using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
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

            GetConfigs();
            
        }

        private async void GetConfigs()
        {
            var restServices = App.Kernel.Get<IRestServices>();
            App.Configs = await restServices.GetConfig();
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