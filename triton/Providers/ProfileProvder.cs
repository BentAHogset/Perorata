using System;
using System.Collections.Generic;
using System.Text;
using triton.Models;
using triton.Services;

namespace triton.Providers
{
    public class ProfileProvder : IProfileProvider
    {
        private IProfileService _profileService;

        public ProfileProvder(IProfileService profileService)
        {
            _profileService = profileService;
        }
        public ProfileModel GetModel()
        {
            return _profileService.GetProfileModel("");
        }
    }
}
