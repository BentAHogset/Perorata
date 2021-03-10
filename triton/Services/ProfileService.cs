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
                ContactInfo = new List<ProfileObject>
                {
                    
                        new ProfileObject { TextValue = "E-post", DataValue = "bent.arne@hotmail.com" },
                        new ProfileObject { TextValue = "Telefon", DataValue = "98222666" },
                        new ProfileObject { TextValue = "Mobil", DataValue = "38086702" },
                    
                    //Email = new ProfileObject { TextValue = "E-post", DataValue = "bent.arne@hotmail.com" },
                    //Phone = "98222666",
                    //Mobile = "98222666"
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
