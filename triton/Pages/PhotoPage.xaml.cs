using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triton.Providers;
using triton.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoPage : ContentPage
    {
        private ProfileViewModel _model;

        public string FilePath { get; set; }
        public Stream FileStream  {get;set;}

        public PhotoPage(ProfileViewModel model)
        {
            InitializeComponent();
            _model = model;
        }

        private async void TakeAPhotoAsync(object sender, EventArgs e)
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                if (photo != null)
                {
                    var stream  = await photo.OpenReadAsync();
                    image.Source = ImageSource.FromStream(() => { return stream; });
                    FilePath = photo.FullPath;
                    FileStream = stream;
                }
            }
        }

        private async void GetAPhotoAsync(object sender, EventArgs e)
        {
            var photo = await MediaPicker.PickPhotoAsync();
            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
                image.Source = ImageSource.FromStream(() => { return stream;});
                FilePath = photo.FullPath;
                FileStream = stream;
            }
            
        }

        private void SaveAPhoto(object sender, EventArgs e)
        {

            // _model.Model.Picture = File.ReadAllBytes(FilePath);
            // _model.Model.Picture = FileStream;
            _model.Model.ProfilePicture = FilePath;
            Navigation.PopModalAsync();

        }
    }
}