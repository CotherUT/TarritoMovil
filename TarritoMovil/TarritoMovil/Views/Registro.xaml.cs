using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarritoMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public ICommand IniciarSesion => new Command(IrIniciarSesion);

        public void IrIniciarSesion()
        {
           
            Navigation.PushAsync(new Login());
        }
        public Registro()
        {
            InitializeComponent();
            BindingContext=this; 

        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}