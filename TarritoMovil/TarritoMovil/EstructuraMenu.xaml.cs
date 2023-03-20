using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarritoMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstructuraMenu : FlyoutPage
    {
        public EstructuraMenu()
        {
            InitializeComponent();
            App.Navigate = Navegacion;
            App.MenuApp = this;
        }
    }
}