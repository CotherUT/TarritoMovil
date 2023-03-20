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
    public partial class Detalle : ContentPage
    {
        public Detalle()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }

        private void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Producto());
        }

        private void btnVer1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetalleProducto());
        }
    }
}