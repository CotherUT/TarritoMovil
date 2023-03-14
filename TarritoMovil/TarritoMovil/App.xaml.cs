using System;
using TarritoMovil.Views;
using TarritoMovil.Views.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarritoMovil
{
    public partial class App : Application
    {
        public static NavigationPage Navigate { get;  internal set; }
        public static EstructuraMenu MenuApp { get;  internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
