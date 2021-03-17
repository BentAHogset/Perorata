using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triton.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccordionLayout : ContentView
    {
        public AccordionLayout()
        {
            InitializeComponent();
            SetToggleProperties();
        }

        private void SetToggleProperties()
        {
            accordionList.IsVisible = !Collapsed;
            var imgSource = Collapsed ? "arrow_down" : "arrow_up";
            imgToggle.Source = imgSource;
        }

        public string ListNameText 
        { 
            get => (string)GetValue(ListNameTextProperty);
            set => SetValue(ListNameTextProperty, value); 
        }

        private static BindableProperty ListNameTextProperty = BindableProperty.Create(
            propertyName: "ListNameText",
            returnType: typeof(string),
            declaringType: typeof(Label),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: ListNameTextChanged);

        private static void ListNameTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (AccordionLayout)bindable;
            control.lblHeader.Text = newValue as String;
        }

        public ObservableCollection<ProfileObject> ListItems
        {
            get => (ObservableCollection<ProfileObject>)GetValue(ListItemsProperty);
            set => SetValue(ListItemsProperty, value);
        }

        public static BindableProperty ListItemsProperty = BindableProperty.Create(
            propertyName: "ListItems",
            returnType: typeof(IEnumerable),
            declaringType: typeof(ListView),
            defaultValue: new ObservableCollection<ProfileObject>(),
            propertyChanged: ListItemsChanged);


        static void ListItemsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var items = (List<ProfileObject>)newValue;
            if (items != null)
            {
                var control = (AccordionLayout)bindable;
                BindableLayout.SetItemsSource(control.accordionList, items);
            }
        }
       

        private bool _collapsed = true;
        public bool Collapsed {
            get
            {
                return _collapsed;
            }
            set
            {
                _collapsed = value;
            }
        
        }

        private void ToggleAccordion(object sender, EventArgs e)
        {
            Collapsed = !Collapsed;
            SetToggleProperties();
        }       
    }
}