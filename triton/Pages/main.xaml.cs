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
        private RestServices restServices = new RestServices();

        public ConfigDTO configs;

        public main()
        {
            InitializeComponent();

            GetConfigs();
            
        }

        private async void GetConfigs()
        {
          configs = await restServices.GetConfig();
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