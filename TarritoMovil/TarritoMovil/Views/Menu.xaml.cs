using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarritoMovil.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarritoMovil.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public List<MenuCLS>ListaMenu { get; set; }
        public Menu()
        {
            InitializeComponent();
            ListaMenu = new List<MenuCLS>();
            ListaMenu.Add(new MenuCLS { icono = "ic_home.png", opcion = "Inicio" });
            ListaMenu.Add(new MenuCLS { icono = "ic_user.png", opcion = "Usuario" });
            ListaMenu.Add(new MenuCLS { icono = "ic_cart.png", opcion = "Carrito" });
            BindingContext = this;
        }
        public void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Se trae la opcion que el usuario selecciono a travez del objeto "e"
            MenuCLS obj_menu = (MenuCLS)e.SelectedItem;

            switch (obj_menu.opcion)
            {
                case "Inicio":
                    App.Navigate.PushAsync(new Login());
                    break;
                case "usuario":
                    App.Navigate.PushAsync(new Producto());
                    break;
                case "Carrito":
                    App.Navigate.PushAsync(new Registro());
                    break;
            }
            App.MenuApp.IsPresented = false; //Oculta el menu cuando el usuario le da click a alguna opcion
        }
    }
}