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
            for (int i = 0; i < 12; i++)
            {
                Children.Add(new Zo(i));
            }
        }
    }
}
