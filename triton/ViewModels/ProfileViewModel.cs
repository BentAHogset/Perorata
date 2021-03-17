using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using triton.Models;
using triton.Providers;
using Xamarin.Forms;

namespace triton.ViewModels
{
    public class ProfileViewModel
    {
        private IProfileProvider _profileProvider;

        public ICommand TapCommand { get; set; }

        public ProfileViewModel(IProfileProvider profileProvider)
        {
            _profileProvider = profileProvider;
            Model = _profileProvider.GetModel();

            TapCommand = new Command(() =>
            {
                //Model.Comment = "";
                //Model.Title = "Kommentaren er lagret";
                //Model.UserInfo
            });
        }

        public ProfileModel Model { get; set; }
    }
}