using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using triton.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccordionListGrouped : ContentView
    {
        public ICommand ToggleCommand { get; set; }

        public AccordionListGrouped()
        {
             
            InitializeComponent();
            SetToggleProperties();
        }

        private void SetToggleProperties()
        {
            //dynamicListGrouped.IsVisible = !Collapsed;

            var imgSource = Collapsed ? "arrow_down" : "arrow_up";
            //imgToggle.Source = imgSource;

            if (Collapsed)
            {
                //dynamicListGrouped.ItemsSource = new ObservableCollection<UserProfile>();
            }
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
        //    var control = (AccordionListGrouped)bindable;
        //    control.lblHeader.Text = newValue as String;
        //}

        public ObservableCollection<UserProfile> ListItems
        {
            get => (ObservableCollection<UserProfile>)GetValue(ListItemsProperty);
            set => SetValue(ListItemsProperty, value);
        }

        public static BindableProperty ListItemsProperty = BindableProperty.Create(
            propertyName: "ListItems",
            returnType: typeof(IEnumerable),
            declaringType: typeof(ListView),
            defaultValue: new ObservableCollection<UserProfile>(),
            propertyChanged: ListItemsChanged);



        static void ListItemsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var items = (List<UserProfile>)newValue;
            if (items != null)
            {
                var control = (AccordionListGrouped)bindable;
                control.dynamicListGrouped.ItemsSource = new ObservableCollection<UserProfile>(items);
                //control.dynamicList.HeightRequest = 45 * items.Count;
            }
        }

        private bool _collapsed = true;
        public bool Collapsed
        {
            get
            {
                return _collapsed;
            }
            set
            {
                _collapsed = value;
            }

        }

       
        


        //private void toggleCommand(object sender)
        //{

        //    Collapsed = !Collapsed;


        //    UserProfile selected = ((UserProfile)(sender));
        //    UserProfile found = ListItems.FirstOrDefault(x => x.Heading == selected.Heading);
        //    found.IsExpanded = !found.IsExpanded;
        //}

            private void ToggleCollapse(object sender, EventArgs e)
        {

            Collapsed = !Collapsed;


            UserProfile selected = ((UserProfile)(sender));
            UserProfile found = ListItems.FirstOrDefault(x => x.Heading == selected.Heading); 
            found.IsExpanded = !found.IsExpanded;
            //UpdateListContent();
            //OnPropertyChanged(new PropertyChangedEventArgs("IsExpanded"));



            //int idx = dynamicListGrouped.ItemsSource.IndexOf("BBB");
            //var index = (ListItems.IndexOf();

            SetToggleProperties();
        }

        
    }
}