using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace triton.Models
{
    public class ProfileObject
    {
        public string TextValue { get; set; }
        public string DataValue { get; set; }
    }

    public class ProfileModel : INotifyPropertyChanged
    {
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private List<ProfileObject> personInfo { get; set; }
        public List<ProfileObject> PersonInfo
        {

            get
            {
                return personInfo;
            }
            set
            {
                personInfo = value;
                NotifyPropertyChanged();
            }
        }


        private List<ProfileObject> addressInfo;
        public List<ProfileObject> AddressInfo
        {
            get
            {
                return addressInfo;
            }
            set
            {
                addressInfo = value;
                NotifyPropertyChanged();
            }

        }


        private List<ProfileObject> contactInfo;
        public List<ProfileObject> ContactInfo
        {
            get
            {
                return contactInfo;
            }
            set
            {
                contactInfo = value;
                NotifyPropertyChanged();
            }
        }

        public List<TaxInfo> Tax { get; set; }

        public List<AccountInfo> Account { get; set; }

        public List<FamilyInfo> Family { get; set; }


    }

    public class AccountInfo
    {
    }

    public class TaxInfo
    {
    }

    public class FamilyInfo
    {
    }
}

   