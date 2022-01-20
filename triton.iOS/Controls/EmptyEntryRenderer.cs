using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using triton.Controls;
using triton.iOS.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EmptyEntry), typeof(EmptyEntryRenderer))]
namespace triton.iOS.Controls
{
    public class EmptyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null && e.NewElement != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
                Control.TextColor = Element.TextColor.ToUIColor();
            }
        }
    }
}