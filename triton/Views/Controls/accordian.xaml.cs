using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class accordian : ContentView
    {
        public accordian()
        {
            InitializeComponent();

            accordianLabel.SetBinding(Label.TextProperty, new Binding("AccordianText", source: this));
            Content.BindingContext = this;
            
            accordianDetails.IsVisible = true;
            accordianImage.Source = "arrow_down";
        }


        public static readonly BindableProperty AccordianTextProperty = BindableProperty.Create("AccordianText",
          typeof(string),
          typeof(Button),
          default(string));


        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }
            set
            {
                SetValue(CommandProperty, value);
            }
        }

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create("Command", typeof(ICommand), typeof(accordian));



        private void accordianTapped(object sender, EventArgs e)
        {
            accordianDetails.IsVisible = !accordianDetails.IsVisible;
            if (accordianDetails.IsVisible)
            {
                accordianImage.Source = "arrow_up";
            }
            else
            {
                accordianImage.Source = "arrow_down";
            }
        }

        public string AccordianText
        {
            get
            {

                return (string)GetValue(AccordianTextProperty);
            }
            set
            {
                SetValue(AccordianTextProperty, value);
            }
        }
    }
}