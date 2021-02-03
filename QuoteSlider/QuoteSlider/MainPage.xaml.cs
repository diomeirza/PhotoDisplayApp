using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuoteSlider
{
    public partial class MainPage : ContentPage
    {
        private string [] quotes = new string[] { "Quote 1", "Quote 2", "Quote 3" }; 
        public MainPage()
        {
            InitializeComponent();
            lblQuote.Text = quotes[0];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string currText = lblQuote.Text;
            int currIndex = Array.IndexOf<string>(quotes, currText);
            lblQuote.Text = quotes[(currIndex + 1) % 3];
        }
    }
}
