using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage()
        {
            InitializeComponent();
        }

        private async void TakeAPhotoAsync(object sender, EventArgs e)
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                if (photo != null)
                {
                    var stream = await photo.OpenReadAsync();


                    image.Source = ImageSource.FromStream(() => { return stream; });

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
            }
        }

        private async void SaveAPhotoAsync(object sender, EventArgs e)
        {

        }
    }
}