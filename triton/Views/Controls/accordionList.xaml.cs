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
            //BindingContext = this;
        }

        //public static readonly BindableProperty LineItemsProperty = BindableProperty.Create("LineItems",
        //  typeof(ObservableCollection<ProfileObject>),
        //  typeof(ListView),
        //  default(ObservableCollection<ProfileObject>));

        //propertyChanged: ListItemsChanged);


        //public static void ListItemsChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var control = (AccordionList)bindable;
        //    //control.dynamicList.ItemsSource = (ObservableCollection<ProfileObject>)newValue;
        //    //control.dynamicList.SetBinding(ListView.ItemsSourceProperty, new Binding("LineItems", source:(ObservableCollection<ProfileObject>)newValue));
        //}

        //private ObservableCollection<ProfileObject> _lineItems;
        //public ObservableCollection<ProfileObject> LineItems
        //{
        //    get
        //    {
        //        return _lineItems;
        //        //return (ObservableCollection<ProfileObject>)GetValue(LineItemsProperty);
        //    }
        //    set
        //    {
        //        //SetValue(LineItemsProperty, value);
        //        if (Equals(value, _lineItems)) return;
        //        _lineItems = value;
        //        OnPropertyChanged(nameof(LineItems));
        //    }
        //}


        //protected override void OnBindingContextChanged()
        //{
        //    base.OnBindingContextChanged();

        //    foreach (var v in ((ContactInfo)BindingContext)))
        //    {
        //        //MyDisplay.Children.Add(v);
        //        //dynamicList.ItemsSource

        //    }
        //}












        //public static readonly BindableProperty LineItemsProperty = BindableProperty.Create(
        //    nameof(LineItems),
        //    typeof(ObservableCollection<ProfileObject>),
        //    typeof(AccordionList),
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: LinesChanged);


        //public static void LinesChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var control = (AccordionList)bindable;
        //    control.dynamicList.ItemsSource = (IEnumerable)newValue;
        //}


        //private ObservableCollection<ContactInfo> itemSource;
        //public ObservableCollection<ContactInfo> ItemsSource
        //{
        //    get { return itemSource; }
        //    set { 
        //        itemSource = value;
        //        this.BindingContext = itemSource;
        //    }
        //}


        //public ObservableCollection<ContactInfo> Items { get; set; }

        //public static readonly BindableProperty ItemsProperty = BindableProperty.Create(
        //    nameof(Items),
        //    typeof(ObservableCollection<ContactInfo>),
        //    typeof(AccordionList),
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: ItemsChanged);

        //public static void ItemsChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var control = (AccordionList)bindable;
        //    control.dynamicList.ItemsSource = (IEnumerable)(ContactInfo)newValue;
        //}


        //public static readonly BindableProperty ItemsSourceProperty =
        //    BindableProperty.Create(
        //        nameof(ItemsSource), 
        //        typeof(IEnumerable),
        //        typeof(AccordionList), 
        //        null,
        //        BindingMode.TwoWay,
        //        propertyChanged:OnItemsSourceChanged);





        //public IEnumerable ItemsSource
        //{
        //    get { return (IEnumerable)GetValue(ItemsSourceProperty); }
        //    set { SetValue(ItemsSourceProperty, value); }
        //}

        //static void OnItemsSourceChanged(BindableObject bindable, object oldvalue, object newvalue)
        //{
        //    var control = (AccordionList)bindable;
        //    control.dynamicList.ItemsSource = (IEnumerable)newvalue;
        //    System.Diagnostics.Debug.WriteLine("source changed");
        //}



        //public IEnumerable ItemsSource
        //{
        //    get { return (IEnumerable)GetValue(ItemsSourceProperty); }
        //    set { SetValue(ItemsSourceProperty, value); }
        //}
        //public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
        //    nameof(ItemsSource), typeof(IEnumerable), typeof(UCListView));



        //private ObservableCollection<object> listSourceObject;
        //public ObservableCollection<object> ListSourceObject {
        //    get
        //    {
        //        return listSourceObject;
        //    }

        //    set {

        //        listSourceObject = value;

        //    } 

        //}

        //public static readonly BindableProperty ListSource = BindableProperty.Create(
        //    propertyName:nameof(ListSourceObject),
        //    returnType:typeof(ObservableCollection<object>),
        //    declaringType: typeof(AccordionList),
        //    defaultValue: new ObservableCollection<object>(),
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: ListSourceChanged);


        //public static void ListSourceChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var control = (AccordionList)bindable;
        //    control.dynamicList.ItemsSource = (List<ProfileObject>)newValue;
        //}

        //public static readonly BindableProperty TestItemsProperty =
        //   BindableProperty.Create(nameof(TestItems), typeof(ObservableCollection<TestModel>), typeof(TestControl), default);

        public string ListNameText { get; set; }

        private static BindableProperty ListNameTextProperty = BindableProperty.Create(
            propertyName: nameof(ListNameText),
            returnType: typeof(string),
            declaringType: typeof(AccordionList),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: ListNameTextChanged);

        private static void ListNameTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (AccordionList)bindable;
            control.lblHeader.Text = newValue.ToString();
        }

        public ObservableCollection<ProfileObject> TestItems
        {
            get => (ObservableCollection<ProfileObject>)GetValue(TestItemsProperty);
            set => SetValue(TestItemsProperty, value);
        }

        public static readonly BindableProperty TestItemsProperty =
            BindableProperty.Create(
                propertyName: "TestItems",
                returnType: typeof(ObservableCollection<ProfileObject>),
                declaringType: typeof(AccordionList),
                propertyChanged: OnEventNameChanged);
        static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Console.WriteLine(newValue.ToString());
            var control = (AccordionList)bindable;
            control.dynamicList.ItemsSource = newValue as ObservableCollection<ProfileObject>;
        }
    }
}