using Ninject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triton.Models;
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
            var model = new ProfileViewModel(profileProvider);

            Content.BindingContext = model;
        }

        private void Closed_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

    }
}