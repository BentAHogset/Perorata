using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                },

                //UserInfo = new List<UserProfile>
                //{
                  //new UserProfile("AdresseInformasjon",new List<ProfileObject>
                  //{
                  //  new ProfileObject { TextValue = "Adresse", DataValue = "Grostølveien 6" },
                  //  new ProfileObject { TextValue = "Postnummer", DataValue = "4634" },
                  //  new ProfileObject { TextValue = "Sted", DataValue = "Kristiansand" },
                  //  new ProfileObject { TextValue = "Land", DataValue = "Norge" }
                  //}),
                  //new UserProfile("Ansattinformasjon",new List<ProfileObject>
                  //{
                  //  new ProfileObject{TextValue ="Ansattnummer",DataValue="1122212"},
                  //  new ProfileObject{TextValue ="Fornavn",DataValue="Bent A."},
                  //  new ProfileObject{TextValue ="Etternavn",DataValue="Høgset"},
                  //  new ProfileObject{TextValue ="Fødselsdato",DataValue="24.06.1972"}
                  //}),
                  //new UserProfile("Kontaktinformasjon", new List<ProfileObject>
                  //{
                  //  new ProfileObject { TextValue = "E-post", DataValue = "bent.arne@hotmail.com" },
                  //  new ProfileObject { TextValue = "Telefonnummer", DataValue = "98222666" },
                  //  new ProfileObject { TextValue = "Mobil", DataValue = "38086702" }
                  //})

                //}
                



            };


            var groupList = new List<UserProfile>();

            var groupAdresseInfo = new UserProfile { Heading = "AdresseInformasjon" };
            groupAdresseInfo.Add(new ProfileObject { TextValue = "Adresse", DataValue = "Grostølveien 6" });
            groupAdresseInfo.Add(new ProfileObject { TextValue = "Postnummer", DataValue = "4634" });
            groupAdresseInfo.Add(new ProfileObject { TextValue = "Sted", DataValue = "Kristiansand S" });
            groupAdresseInfo.Add(new ProfileObject { TextValue = "Land", DataValue = "Norge" });
            groupList.Add(groupAdresseInfo);

            var groupContactInfo = new UserProfile { Heading = "KontaktInformasjon" };
            groupContactInfo.Add(new ProfileObject { TextValue = "Epost", DataValue = "bent.arne@hotmail.com    " });
            groupContactInfo.Add(new ProfileObject { TextValue = "Telefonnummer", DataValue = "98222666" });
            groupContactInfo.Add(new ProfileObject { TextValue = "Mobil", DataValue = "98222666" });
            groupList.Add(groupContactInfo);


            model.UserInfo = groupList;


            

            return model;

        }
    }
}
