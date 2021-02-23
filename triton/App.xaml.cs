using Ninject;
using System;
using triton.Kernels;
using triton.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            var settings = new NinjectSettings
            {
                LoadExtensions = false
            };

            Kernel = new StandardKernel(settings, new CommonModule());

            

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new main());


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
