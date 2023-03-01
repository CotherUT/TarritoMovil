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
    public partial class Login : ContentPage
    {
        public ICommand Registrarse => new Command(IrRegistrarse);

        public void IrRegistrarse()
        {

            Navigation.PushAsync(new MainPage()); //Borrar esto y usar el comentario de abajo ya que el login este terminado
            //Navigation.PushAsync(new Login());
        }
        public Login()
        {
            InitializeComponent();
            BindingContext= this;
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
         
        }
    }
}