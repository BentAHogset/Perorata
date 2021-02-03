using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class main : ContentPage
    {
        public ICommand ClickVacation;

        public main()
        {
            InitializeComponent();
            

            ClickVacation = new Command(() =>
            {
                Navigation.PushAsync(new vacation());
            });
        }

        private void Vacation_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new vacation());
        }
        
    }
}