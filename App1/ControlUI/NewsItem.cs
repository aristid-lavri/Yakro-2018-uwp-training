using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace App1.ControlUI
{
    public sealed class NewsItem : Windows.UI.Xaml.Controls.Control
    {

        public static readonly DependencyProperty HeaderTextContentProperty = 
            DependencyProperty.Register("HeaderTextContent", typeof(string), typeof(NewsItem), new PropertyMetadata(string.Empty, HeaderTextContentCallback));

        public static readonly DependencyProperty TextContentProperty = 
            DependencyProperty.Register("TextContent", typeof(string), typeof(NewsItem), new PropertyMetadata(string.Empty, TextContentCallback));

        public static readonly DependencyProperty ImageSourceProperty = 
            DependencyProperty.Register("ImageSource", typeof(string), typeof(NewsItem), new PropertyMetadata(string.Empty, ImageSourceCallback));






        public string HeaderTextContent
        {
            get => (string)GetValue(HeaderTextContentProperty);
            set => SetValue(HeaderTextContentProperty, value);
        }

        public string TextContent
        {
            get => (string)GetValue(TextContentProperty);
            set => SetValue(TextContentProperty, value);
        }

        public string ImageSource
        {
            get => (string)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }


        private static void HeaderTextContentCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue != e.NewValue)
            {
                NewsItem._HeaderTextContent.Text = (string)e.NewValue;
            }
        }

        private static void TextContentCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue != e.NewValue)
            {
                NewsItem._TextContent.Text = (string)e.NewValue;
            }
        }

        private static void ImageSourceCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue != e.NewValue)
            {
                var source = (string)e.NewValue;
                NewsItem._ImageContent.Source = null;

                Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage = new
                Windows.UI.Xaml.Media.Imaging.BitmapImage { UriSource = new Uri(source, UriKind.RelativeOrAbsolute) };
                NewsItem._ImageContent.Source = bitmapImage;
            }
        }

        private static TextBlock _HeaderTextContent;
        private static TextBlock _TextContent;
        private static Image _ImageContent;

        public NewsItem()
        {
            this.DefaultStyleKey = typeof(NewsItem);
        }

        protected override void OnApplyTemplate()
        {
            _HeaderTextContent = GetTemplateChild("HeaderTextContent") as TextBlock;
            _TextContent = GetTemplateChild("TextContent") as TextBlock;
            _ImageContent = GetTemplateChild("ImageContent") as Image;

            _HeaderTextContent.Text = (string)GetValue(HeaderTextContentProperty);
            _TextContent.Text = (string)GetValue(TextContentProperty);
            Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage = new
                Windows.UI.Xaml.Media.Imaging.BitmapImage { UriSource = new Uri("ms-appx:///Assets/Wikipedia_User-ICON_byNightsight.png", UriKind.RelativeOrAbsolute) };

            _ImageContent.Source = bitmapImage;
            base.ApplyTemplate();
        }
    }
}
