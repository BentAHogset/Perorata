using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class app_button : ContentView
    {
        public app_button()
        {
            InitializeComponent();
            lblButton.SetBinding(Label.TextProperty, new Binding("LabelText", source: this));
        }

        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(
           nameof(LabelText),
           typeof(string),
           typeof(Label),
           string.Empty);

        public string LabelText
        {
            get
            {

                return (string)GetValue(LabelTextProperty);
            }
            set
            {
                SetValue(LabelTextProperty, value);
            }
        }

    }
}