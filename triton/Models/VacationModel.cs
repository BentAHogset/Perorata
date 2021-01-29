using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace triton.Models
{
    public class VacationModel :INotifyPropertyChanged
    {

        private string title;
        private string comment;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title
        {
            get
            {
                return title;
            }
            set {
                title = value;
                NotifyPropertyChanged();
            }
        }
        
        public string Comment { 
            get {
                return comment;
            }
            set {
                comment = value;
                NotifyPropertyChanged();
            } 
        }
    }
}
    
