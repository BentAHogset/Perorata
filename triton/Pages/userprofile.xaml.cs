﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class userprofile : ContentPage
    {
        public userprofile()
        {
            InitializeComponent();
        }

        private void Closed_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}