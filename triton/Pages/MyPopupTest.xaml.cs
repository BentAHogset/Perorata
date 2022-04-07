using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using triton.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace triton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopupTest : Rg.Plugins.Popup.Pages.PopupPage
    {
        public MyPopupTest(PopupOptions options)
        {
            InitializeComponent();

            this.PopupContent.Margin = options.Margins;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
            
        }
    }
}