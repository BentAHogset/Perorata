using System;
using System.Collections.Generic;
using System.Text;
using triton.Models;
using triton.Providers;

namespace triton.ViewModels
{
    public class ProfileViewModel
    {
        private IProfileProvider _profileProvider;

        public ProfileViewModel(IProfileProvider profileProvider)
        {
            _profileProvider = profileProvider;
            Model = _profileProvider.GetModel();
        }

        public ProfileModel Model { get; set; }
    }
}