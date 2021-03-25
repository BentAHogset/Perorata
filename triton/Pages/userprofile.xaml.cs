using Ninject;
using Plugin.Media;
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
       
        public ProfileViewModel Model { get; set; }
        public userprofile()
        {
            InitializeComponent();
            var profileProvider = App.Kernel.Get<IProfileProvider>();
            Model = new ProfileViewModel(profileProvider);

            Content.BindingContext = Model;
        }

        private void Closed_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PhotoPage(Model));


            //await CrossMedia.Current.Initialize();

            //if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            //{
            //    Console.WriteLine("No Camera", ":( No camera available.", "OK");
            //    return;
            //}

            //var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            //{
            //    Directory = "Sample",
            //    Name = "test.jpg"


            //});

            //if (file == null) return;

            //imgProfile.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    return stream;
            //});

        }
    }
}