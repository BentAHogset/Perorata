using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void Vacation_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new vacation());
        }
    }
}