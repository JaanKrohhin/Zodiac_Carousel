using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Zodiac_Carousel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var r = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label{ Text = "Red", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), HorizontalOptions = LayoutOptions.Center},
                        new BoxView{ Color = Color.Red, WidthRequest = 200, HeightRequest = 200, HorizontalOptions = LayoutOptions.Center }
                    }
                }
            };
            var g = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label{ Text = "Green", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), HorizontalOptions = LayoutOptions.Center},
                        new BoxView{ Color = Color.Green, WidthRequest = 200, HeightRequest = 200, HorizontalOptions = LayoutOptions.Center }
                    }
                }
            };
            var b = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label{ Text = "Blue", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), HorizontalOptions = LayoutOptions.Center},
                        new BoxView{ Color = Color.Blue, WidthRequest = 200, HeightRequest = 200, HorizontalOptions = LayoutOptions.Center }
                    }
                }
            };
            for (int i = 0; i < 12; i++)
            {
                Children.Add(new Zo(i));
            }
        }
    }
}
