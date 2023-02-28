using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TarritoMovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Login());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Registro());
        }

        private void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {

        }


    }
}
