using System;
using System.Collections.Generic;
using System.Text;
using triton.Models;

namespace triton.Services
{
    public class ProfileService : IProfileService
    {
        public ProfileModel GetProfileModel(string userId)
        {

            var model = new ProfileModel
            {
                Contact = new ContactInfo
                {
                    Email = "bent.arne@hotmail.com",
                    Phone = "98222666",
                    Mobile = "98222666"
                },
                Address = new AddressInfo
                { 
                    Address1 = "Grostølveien 6",
                    ZipCode = "4634",
                    City = "Kristiansand",
                    Country = "Norge"
                }
            };
            return model;

        }
    }
}
