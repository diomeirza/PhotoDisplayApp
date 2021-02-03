using QuoteSlider.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuoteSlider
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ImageUI();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
