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

        public PersonInfo Person { get; set; }

        public AddressInfo Address { get; set; }


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


     public class AddressInfo
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}

    public class PersonInfo
    {
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }

    }