using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Graphics.Drawables;
using triton.Controls;
using triton.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EmptyEntry), typeof(EmptyEntryRenderer))]
namespace triton.Droid.Controls
{
    public class EmptyEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="context"></param>
        public EmptyEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackground(gd);
                Control.SetTextColor(Element.TextColor.ToAndroid());
            }
        }
    }
}