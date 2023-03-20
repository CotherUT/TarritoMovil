using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarritoMovil.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarritoMovil
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleProducto : ContentPage

	{
		public DetalleProducto ()
		{
			InitializeComponent ();
			List<GaleriaCLS> obj_imagen=new List<GaleriaCLS>()
			{
				new GaleriaCLS() 
				{ titulo = "imagen1", imagen = "arete01.jpg" },
				new GaleriaCLS() 
				{ titulo = "imagen2", imagen = "arete02.jpg" }
			};
			Carousel.ItemsSource = obj_imagen;
		}

        private void btnVer1_Clicked(object sender, EventArgs e)
        {

        }
    }
}