using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zodiac_Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Zo : ContentPage
    {
        public Zo(int _index)
        {
            InitializeComponent();
            BindingContext = this;
            en.Text = Properties.Resources.ResourceManager.GetString("_" + _index.ToString());
            img.Source = ImageSource.FromResource("Zodiac_Carousel.Resources._" + _index.ToString() + ".jpg");
        }
    }
}