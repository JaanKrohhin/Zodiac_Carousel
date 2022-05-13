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
        private int IndexOfTextArray = 1;
        private string[] Arraytext;
        public Zo(int _index)
        {
            InitializeComponent();
            BindingContext = this;
            Arraytext = Properties.Resources.ResourceManager.GetString("_" + _index.ToString()).Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            en.Text = Arraytext[0];
            img.Source = ImageSource.FromResource("Zodiac_Carousel.Resources._" + _index.ToString() + ".jpg");
        }


        private void MoreText(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var returnString = Arraytext[IndexOfTextArray];
            if (IndexOfTextArray == Arraytext.Length-1)
            {
                IndexOfTextArray = 0;
            }
            else
            {
                IndexOfTextArray++;
            }
            en.Text = returnString;
        }
    }
}