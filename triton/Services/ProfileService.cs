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
                PersonInfo = new List<ProfileObject>
                {
                    new ProfileObject{TextValue ="Ansattnummer",DataValue="1122212"},
                    new ProfileObject{TextValue ="Fornavn",DataValue="Bent A."},
                    new ProfileObject{TextValue ="Etternavn",DataValue="Høgset"},
                    new ProfileObject{TextValue ="Fødselsdato",DataValue="24.06.1972"}
                },
                
                ContactInfo = new List<ProfileObject>
                {
                    new ProfileObject { TextValue = "E-post", DataValue = "bent.arne@hotmail.com" },
                    new ProfileObject { TextValue = "Telefonnummer", DataValue = "98222666" },
                    new ProfileObject { TextValue = "Mobil", DataValue = "38086702" }
                },
                AddressInfo = new List<ProfileObject>
                {
                    new ProfileObject { TextValue = "Adresse", DataValue = "Grostølveien 6" },
                    new ProfileObject { TextValue = "Postnummer", DataValue = "4634" },
                    new ProfileObject { TextValue = "Sted", DataValue = "Kristiansand" },
                    new ProfileObject { TextValue = "Land", DataValue = "Norge" }
                }
                
            };
            return model;

        }
    }
}
