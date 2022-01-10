using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopupTest : Rg.Plugins.Popup.Pages.PopupPage
    {
        public MyPopupTest()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
            
        }
    }
}