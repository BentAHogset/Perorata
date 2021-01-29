using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BgButton : ContentView
    {
        public BgButton()
        {
            InitializeComponent();

            customButton.SetBinding(Button.TextProperty, new Binding("ButtonText", source:this)) ;
        }


        public static readonly BindableProperty ButtonTextProperty =
            BindableProperty.Create("ButtonText", typeof(string), typeof(Button), default(string));


        public static readonly BindableProperty CommandProperty = 
            BindableProperty.Create("Command", typeof(ICommand), typeof(Button), null);


        public string ButtonText
        {
            get {

                return (string)GetValue(ButtonTextProperty);
            }
            set
            {
                SetValue(ButtonTextProperty, value);
            }
        }

        public ICommand Command {

            get
            {
                return (ICommand)GetValue(CommandProperty);
            }
            set
            {
                SetValue(CommandProperty, value);
            }
        }

       // public event EventHandler Clicked;


    }
}