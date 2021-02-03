using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuoteSlider.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageUI : ContentPage
    {
        private int imageId;
        private readonly string imgSource = "https://loremflickr.com/1920/1080/";
        public ImageUI()
        {
            InitializeComponent();
            imageId = 1;
            image.Source = GetImageSource();
        }

        private void BtnPrev_Clicked(object sender, EventArgs e)
        {
            image.Source = GetImageSource();
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            image.Source = GetImageSource();
        }

        private UriImageSource GetImageSource()
        {
            imageId = imageId == 10 ? 0 : imageId;
            imageId++;
            string uriString = String.Format("{0}{1}", imgSource, imageId);
            UriImageSource imgURI = new UriImageSource
            {
                Uri = new Uri(uriString),
                CachingEnabled = false
            };
            return imgURI;
        }
    }
}