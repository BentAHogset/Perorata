using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triton.Providers;
using triton.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class userprofile : ContentPage
    {
        public userprofile()
        {
            InitializeComponent();
            var profileProvider = App.Kernel.Get<IProfileProvider>();
            BindingContext = new ProfileViewModel(profileProvider);
        }

        private void Closed_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Toggle_user(object sender, EventArgs e)
        {
            expand.IsVisible = !expand.IsVisible;
            if(expand.IsVisible)
            {
                img.Source = "arrow_up";
            }
            else
            {
                img.Source = "arrow_down";
            }
        }
    }
}