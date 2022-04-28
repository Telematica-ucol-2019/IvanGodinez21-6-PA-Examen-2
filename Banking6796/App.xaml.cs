using Banking6796.Views6796;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Banking6796
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new RegisterPage6796());
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
