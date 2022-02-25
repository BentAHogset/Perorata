using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace triton.Controls
{
    public class  EmptyEntry : Entry
    {
    }

    public class TextBox : StackLayout
    {
        private readonly Frame _frmBackground = new Frame { BackgroundColor = Color.White, CornerRadius = (float)3, BorderColor = Color.LightGray, Padding = new Thickness(10, 0, 0, 0), HasShadow = false, Margin= new Thickness(10,0,10,0)};
        private readonly Label _lblTitle = new Label { Margin = new Thickness(6, 0, 0, 0), IsVisible = false, LineBreakMode = LineBreakMode.TailTruncation};
        private readonly Image _imgIcon = new Image { InputTransparent = true, IsVisible = false, Margin = new Thickness(5, 10, 10, 10), VerticalOptions = LayoutOptions.CenterAndExpand, HeightRequest = 35, BackgroundColor=Color.Transparent};
        private readonly Entry _txtInput;

        public TextBox()
        {
            _txtInput = GetInputEntry();
            _txtInput.TextChanged += TxtInput_TextChanged;


            this.Children.Add(_lblTitle);
            this.Children.Add(_frmBackground);

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
                    }
                }
            };
        }

        private void TxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetValue(TextProperty, _txtInput.Text);
            _imgIcon.IsVisible = string.IsNullOrEmpty(_txtInput.Text);
        }

        private protected Entry GetInputEntry()
        {
            return new EmptyEntry
            {
                TextColor = Color.Black,
                PlaceholderColor = Color.LightGray,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.White,
                WidthRequest = 100
            };
        }

        public string Title { get => _lblTitle.Text; set { _lblTitle.Text = value; _lblTitle.IsVisible = !string.IsNullOrEmpty(value); } }
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(TextBox), null, propertyChanged: (bo, ov, nv) => ((TextBox) bo).Title = (string)nv);
        public string Text { get => _txtInput.Text; set { _txtInput.Text = value; OnPropertyChanged(); } }
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(TextBox), null, BindingMode.TwoWay, propertyChanged: (bo, ov, nv) => ((TextBox) bo).Text = (string)nv);

        public string IconImage { get => _imgIcon.Source.ToString(); set { _imgIcon.IsVisible = !string.IsNullOrEmpty(value); _imgIcon.Source = value; } }
        public static readonly BindableProperty IconImageProperty = BindableProperty.Create(nameof(IconImage), typeof(string), typeof(TextBox), null, propertyChanged: (bo, ov, nv) => ((TextBox) bo).IconImage = (string)nv);
    }
}