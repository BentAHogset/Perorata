using System;
using System.Collections.Generic;
using System.Text;

namespace triton.Models
{
    public class ProfileModel
    {
        public PersonInfo Person { get; set; }

        public AddressInfo Address { get; set; }

        public ContactInfo Contact { get; set; }

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

    public class ContactInfo
    {
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }

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