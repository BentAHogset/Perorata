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
      

        public Command SaveCommand { get; set; }

        public VacationViewModel(IVacationProvider vacationProvider)
        {
            this.vacationProvider = vacationProvider;
            Model = this.vacationProvider.GetModel();
            
            SaveCommand = new Command(() =>
            {
                Model.Comment = "";
                Model.Title = "Kommentaren er slettet";
            });
            
        }
      
        public VacationModel Model { get; set; }
        
    }
}
