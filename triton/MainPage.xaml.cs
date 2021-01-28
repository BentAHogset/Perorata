using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triton.Views;
using Xamarin.Forms;

namespace triton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void Vacation_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new vacation());
        }
    }
}
