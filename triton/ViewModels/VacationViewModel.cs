using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using triton.Models;
using triton.Providers;
using triton.Services;

namespace triton.ViewModels
{
    public class VacationViewModel: ViewModelBase  //: INotifyPropertyChanged
    {
        private readonly IVacationProvider vacationProvider;
        private readonly VacationModel vacationModel;

        public VacationViewModel(IVacationProvider provider)
        {
            //vacationService = new VacationService();
            vacationProvider = provider;
            vacationModel = vacationProvider.GetModel();
        }

        //public VacationViewModel(IVacationService service)
        //{
        //    vacationService = service;
        //    vacationModel = vacationService.GetVacationModel(0);
        //}

        public string Title
        {
            get
            {
                return vacationModel.Title;
            }
            set
            {
                vacationModel.Title = value;
            }

        }



        //public event PropertyChangedEventHandler PropertyChanged;

        //private string title;
        //public string Title
        //{ get
        //    {
        //        return title;
        //    }
        //    set
        //    {
        //        title = value;
        //        var args = new PropertyChangedEventArgs(nameof(Title));
        //        PropertyChanged?.Invoke(this, args);
        //    }
        //}
    }
}
