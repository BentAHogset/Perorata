using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lists : ContentPage
    {
        public List<string> People { get; set; }

        
        public Lists()
        {
            InitializeComponent();

            People = new List<string>
            {
                "Alan",
                "Betty",
                "Charles",
                "David"
            };

            //CV.BindingContext = this;
            BindingContext = this;
        }
    }
}