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
    }
}