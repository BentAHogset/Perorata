﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace triton.Controls
{
    public class EmptyEntry : Entry
    {
        
    }

    public class SuperEntry : StackLayout
    {
        //private readonly Label _label = new Label {Text = "Bent"};

        //public SuperEntry()
        //{
        //    this.Children.Add(_label);
        //}

        readonly Frame _frmBackground = new Frame { BackgroundColor = Color.LightGray, CornerRadius = (float)5, BorderColor = Color.Black, Padding = new Thickness(5, 0, 0, 0), HasShadow = false };
        readonly Label _lblTitle = new Label { Margin = new Thickness(6, 0, 0, 0), IsVisible = true, LineBreakMode = LineBreakMode.TailTruncation };
        readonly Label _lblAnnotation = new Label { Margin = new Thickness(6, 0, 0, 0), IsVisible = true, FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)), Opacity = 0.8 };
        readonly Image _imgWarning = new Image { Margin = 10, HorizontalOptions = LayoutOptions.End, VerticalOptions = LayoutOptions.Center, InputTransparent = true, Source = "alert.png" };
        readonly Image _imgIcon = new Image { InputTransparent = true, IsVisible = true, Margin = new Thickness(5, 10, 10, 10), VerticalOptions = LayoutOptions.CenterAndExpand, HeightRequest = 30 };
        readonly Entry _txtInput;

        public SuperEntry()
        {
            _txtInput = GetInputEntry();
            

            this.Children.Add(_lblTitle);
            this.Children.Add(_frmBackground);

            _imgIcon.Source = "lonn";

            _frmBackground.Content = new Grid
            {
                BackgroundColor = Color.Transparent,
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        BackgroundColor = Color.Transparent,

                        Children =
                        {
                            _txtInput,
                            _imgIcon

                        }
                    },
                    _imgWarning
                }
            };
        }

        private protected Entry GetInputEntry()
        {
            var entry = new EmptyEntry
            {
                TextColor = Color.White,//GlobalSetting.TextColor,
                PlaceholderColor = Color.LightGray,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                //FontFamily =//GlobalSetting.FontFamily,
                BackgroundColor = Color.Transparent, //= Colors.Transparent,
        };
            return entry;


        }


    }
}