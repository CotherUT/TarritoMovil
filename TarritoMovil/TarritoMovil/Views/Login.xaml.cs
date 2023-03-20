using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TarritoMovil.Clases;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarritoMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage

    {
        public ICommand Registrarse => new Command(IrRegistrarse);

        public void IrRegistrarse()
        {

           
            Navigation.PushAsync(new Registro());
        }

        public UsuarioCLS Obj_Login { get; set; } = new UsuarioCLS();
        public Login()
        {
            InitializeComponent();
            BindingContext= this;
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (Obj_Login.Usuario == "Admin" && Obj_Login.Password == "123")
            {
                Application.Current.MainPage = new EstructuraMenu();
            }
            else
            {
                DisplayAlert("Error", "Usuario y/o contraseña incorrectas", "Cancelar");
            }
        }
    }
}