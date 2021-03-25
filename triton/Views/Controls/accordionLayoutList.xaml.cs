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
    public partial class AccordionLayoutList : ContentView
    {
        public AccordionLayoutList()
        {
            InitializeComponent();
            SetToggleProperties();
        }

        private void SetToggleProperties()
        {
            accordionList.IsVisible = ListItems.IsExpanded;
            imgToggle.Source = ListItems.IsExpanded ? "arrow_up" : "arrow_down";
        }

        //public string ListNameText
        //{
        //    get => (string)GetValue(ListNameTextProperty);
        //    set => SetValue(ListNameTextProperty, value);
        //}

        //private static BindableProperty ListNameTextProperty = BindableProperty.Create(
        //    propertyName: "ListNameText",
        //    returnType: typeof(string),
        //    declaringType: typeof(Label),
        //    defaultValue: "",
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: ListNameTextChanged);

        //private static void ListNameTextChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var control = (AccordionLayoutList)bindable;
        //    control.lblHeader.Text = newValue as String;
        //}

        public UserProfile ListItems
        {
            get => (UserProfile)GetValue(ListItemsProperty);
            set 
            {
                SetValue(ListItemsProperty, value); 
            }
        }

        public static BindableProperty ListItemsProperty = BindableProperty.Create(
            propertyName: "ListItems",
            returnType: typeof(UserProfile),
            declaringType: typeof(StackLayout),
            defaultValue: new UserProfile(),
            propertyChanged: ListItemsChanged);


        static void ListItemsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var userProfile =  newValue as UserProfile;
            if (userProfile != null)
            {
                var control = (AccordionLayoutList)bindable;
                control.accordionMain.BindingContext = userProfile;
                control.heading.Text = userProfile.Heading;
                BindableLayout.SetItemsSource(control.accordionList, userProfile);
            }
        }

        private static string headings;
        public static string Headings {
            get{ 
                return headings; 
            } set 
            {
                headings = value; } 
        }


        private void ToggleAccordion(object sender, EventArgs e)
        {
            ListItems.IsExpanded = !ListItems.IsExpanded;
            SetToggleProperties();
        }

        private void accordionList_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //if (e.PropertyName != "IsVisible") return;
            //var viewModel = (StackLayout)sender;
            //if(!viewModel.IsVisible)
            //    viewModel.FadeTo(0, 5000);
            //if (viewModel.IsVisible)
            //    viewModel.FadeTo(5000, 0);
        }
    }
}