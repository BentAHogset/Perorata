using Ninject;
using System;
using triton.Kernels;
using triton.Pages;
using triton.Rest;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            Device.SetFlags(new string[] { "Expander_Experimental", "Shell_UWP_Experimental" });

            var settings = new NinjectSettings
            {
                LoadExtensions = false
            };

            Kernel = new StandardKernel(settings, new CommonModule());

            //MainPage = new NavigationPage(new main());
            MainPage = new AppShell();

        }
        

        public static Ninject.IKernel Kernel
        {
            get;
            set;
        }

        public static ConfigDTO Configs 
        {
            get; 
            set;
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
