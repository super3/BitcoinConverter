using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Bitcoin_Converter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public double rate = 11.07;
        public bool flag = false;

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btcBox_TextChanged(object sender, Windows.UI.Xaml.Controls.TextChangedEventArgs e)
        {
            if (!flag)
            {

                try
                {
                    double btc = double.Parse(btcBox.Text);
                    usdBox.Text = Math.Round((rate * btc), 3).ToString();
                    flag = true;
                }
                catch
                {
                    // Do Nothing 
                }
            }
            else
            {
                flag = false;
            }
        }

        private void usdBox_TextChanged(object sender, Windows.UI.Xaml.Controls.TextChangedEventArgs e)
        {
            if (!flag)
            {
                try
                {
                    double usd = double.Parse(usdBox.Text);
                    btcBox.Text = Math.Round((usd / rate), 3).ToString();
                    flag = true;
                }
                catch
                {
                    // Do Nothing 
                }
            }
            else
            {
                flag = false;
            }
        }

        private void usdBox_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
        }
    }
}
