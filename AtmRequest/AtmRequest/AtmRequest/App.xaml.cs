using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtmRequest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AccountPage())
            {
                BarBackgroundColor = Color.White
            };
        }
    }
}
