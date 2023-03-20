using System;
using TarritoMovil.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarritoMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Producto());
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
