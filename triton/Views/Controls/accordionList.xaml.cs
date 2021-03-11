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
    public partial class AccordionList : ContentView
    {
        public AccordionList()
        {
            InitializeComponent();
            SetToggleProperties();
        }

        private void SetToggleProperties()
        {
            dynamicList.IsVisible = !Collapsed;

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
            var control = (AccordionList)bindable;
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
            propertyChanged: TestItemsChanged);
        
        static void TestItemsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var items = (List<ProfileObject>)newValue;
            if (items != null)
            {
                var control = (AccordionList)bindable;
                control.dynamicList.ItemsSource = items;
                control.dynamicList.HeightRequest = 45 * items.Count;
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

        private void ToggleCollapse(object sender, EventArgs e)
        {
            Collapsed = !Collapsed;
            SetToggleProperties();
        }
    }
}