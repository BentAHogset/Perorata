﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using triton.Controls;
using triton.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(DropDown), typeof(DropDownRenderer))]
namespace triton.Droid.Controls
{
    
    public class DropDownRenderer : ViewRenderer<DropDown, Spinner>
    {
        Spinner spinner;
        public DropDownRenderer(Context context) : base(context)
        {


        }

        protected override void OnElementChanged(ElementChangedEventArgs<DropDown> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                spinner = new Spinner(Context);
                SetNativeControl(spinner);
            }

            if (e.OldElement != null)
            {
                Control.ItemSelected -= OnItemSelected;
            }
            if (e.NewElement != null)
            {
                var view = e.NewElement;

                ArrayAdapter adapter = new ArrayAdapter(Context , Android.Resource.Layout.SimpleListItem1, view.ItemsSource);
                Control.Adapter = adapter;

                if (view.SelectedIndex != -1)
                {
                    Control.SetSelection(view.SelectedIndex);
                }

                Control.ItemSelected += OnItemSelected;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var view = Element;
            if (e.PropertyName == DropDown.ItemsSourceProperty.PropertyName)
            {
                ArrayAdapter adapter = new ArrayAdapter(Context, Android.Resource.Layout.SimpleListItem1, view.ItemsSource);
                Control.Adapter = adapter;
            }
            if (e.PropertyName == DropDown.SelectedIndexProperty.PropertyName)
            {
                Control.SetSelection(view.SelectedIndex);
            }
            base.OnElementPropertyChanged(sender, e);
        }

        private void OnItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var view = Element;
            if (view != null)
            {
                view.SelectedIndex = e.Position;
                view.OnItemSelected(e.Position);
            }
        }
    }
}