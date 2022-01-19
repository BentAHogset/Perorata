using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triton.Controls;
using triton.Models;
using triton.Providers;
using triton.Services;
using triton.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vacation : ContentPage
    {

        public List<string> Items1 = new List<string>();
        public List<string> Items2 = new List<string>();
        public bool IsItem1 = true;

        public vacation()
        {
            InitializeComponent();

            var vacationProvider = App.Kernel.Get<IVacationProvider>();
            BindingContext = new VacationViewModel(vacationProvider);


            for (int i = 0; i < 4; i++)
            {
                Items1.Add(i.ToString());
            }

            for (int i = 0; i < 10; i++)
            {
                Items2.Add(i.ToString());
            }

            DropDown.ItemsSource = Items1;
            DropDown.SelectedIndex = 1;
            DropDown.ItemSelected += OnDropdownSelected;
        }


        private void OnDropdownSelected(object sender, DropDown.ItemSelectedEventArgs e)
        {
            //label.Text = IsItem1 ? Items1[e.SelectedIndex] : Items2[e.SelectedIndex];
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            DropDown.ItemsSource = IsItem1 ? Items2 : Items1;
            DropDown.SelectedIndex = IsItem1 ? 5 : 1;
            IsItem1 = !IsItem1;
        }
    }
}