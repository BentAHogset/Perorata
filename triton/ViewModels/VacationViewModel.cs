using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using triton.Models;
using triton.Providers;
using triton.Services;
using Xamarin.Forms;

namespace triton.ViewModels
{
    public class VacationViewModel: ViewModelBase
    {
        private readonly IVacationProvider vacationProvider;
      

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand NextCommand { get; set; }

        public VacationViewModel(IVacationProvider vacationProvider)
        {
            this.vacationProvider = vacationProvider;
            Model = this.vacationProvider.GetModel();
            
            SaveCommand = new Command(() =>
            {
                //Model.Comment = "";
                Model.Title = "Kommentaren er lagret";
            });

            DeleteCommand = new Command(() =>
            {
                Model.Comment = "";
                Model.Title = "Kommentaren er slettet";
            });

            CancelCommand = new Command(() =>
            {
                //Model.Comment = "";
                Model.Title = "Handlingen er avbrutt";
            });

            NextCommand = new Command(() =>
            {
                //Model.Comment = "";
                Model.Title = "Neste er klikket";
            });

        }
      
        public VacationModel Model { get; set; }
        
    }
}
