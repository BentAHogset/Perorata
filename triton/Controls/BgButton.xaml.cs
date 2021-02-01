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
            Content.BindingContext = this;
        }


        public static readonly BindableProperty ButtonTextProperty = BindableProperty.Create("ButtonText", 
            typeof(string), 
            typeof(Button), 
            default(string));

        public static readonly BindableProperty CommandProperty =  BindableProperty.Create(nameof(Command),
            typeof(ICommand), 
            typeof(BgButton), 
            default(ICommand));

        public static readonly BindableProperty CommandParameterProperty =  BindableProperty.Create(nameof(CommandParameter),
            typeof(object),
            typeof(BgButton));


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

        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }


        // public event EventHandler Clicked;


    }
}