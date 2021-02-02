using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class testview : ContentView
    {
        public testview()
        {
            InitializeComponent();
            BindingContext = null;
        }
    }
}