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
    public partial class absence : ContentPage
    {
        public absence()
        {
            InitializeComponent();
            

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            historicAbsence.ItemsSource = new List<string> { "Bent", "Heidi", "Magdalena", "Jonas","Benjamin","Berglind" };
        }
    }
}