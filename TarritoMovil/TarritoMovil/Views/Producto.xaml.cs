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
	public partial class Producto : ContentPage
	{
		public Producto ()
		{
			InitializeComponent ();
		}

        private void tbPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;
            var amt = e.NewTextValue.Replace("$", "");


            if (decimal.TryParse(amt, out decimal num))
            {
                // Init our number
                if (string.IsNullOrEmpty(e.OldTextValue))
                {
                    num = num / 100;
                }

                // Shift decimal to right if added a decimal digit
                else if (num.DecimalDigits() > 2 && !e.IsDeletion())
                {
                    num = num * 10;
                }

                // Shift decimal to left if deleted a decimal digit
                else if (num.DecimalDigits() < 2 && e.IsDeletion())
                {
                    num = num / 10;
                }

                entry.Text = num.ToString("C");
            }

            else
            {
                entry.Text = e.OldTextValue;
            }
        }
    }

    public static class ExtensionMethods
    {
        public static int DecimalDigits(this decimal n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture)

                    .SkipWhile(c => c != '.')

                    .Skip(1)

                    .Count();
        }

        public static bool IsDeletion(this TextChangedEventArgs e)
        {
            return !string.IsNullOrEmpty(e.OldTextValue) && e.OldTextValue.Length > e.NewTextValue.Length;
        }

    }
}