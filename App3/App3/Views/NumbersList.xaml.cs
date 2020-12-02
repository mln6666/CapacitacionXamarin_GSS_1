using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NumbersList : ContentPage
    {
        public NumbersList()
        {
            InitializeComponent();
        }

        private void new_List_Clicked(object sender, EventArgs e)
        {
            if (int.Parse(entryNumber.Text) == 0 || int.Parse(entryNumber.Text) > 25)
            {
                DisplayAlert("Aviso", "Debe ingresar un número dentro del rango 1-25", "OK");

            }
            else
            {
                EntriesStackLayout.Children.Clear();
                EntriesStackLayout.BackgroundColor = RandomColor();
                for (int i = 1; i <= int.Parse(entryNumber.Text); i++)
                {

                    Entry newEntry = new Entry();
                    newEntry.Text = i.ToString();
                    newEntry.HorizontalTextAlignment = TextAlignment.Center;
                    newEntry.FontAttributes = FontAttributes.Italic;
                    newEntry.TextColor = RandomColor();
                    newEntry.IsReadOnly = true;
                    EntriesStackLayout.Children.Add(newEntry);
                }
                DisplayAlert("Aviso", "Listado generado exitosamente!", "OK");
            }
        }

        public Color RandomColor()
        {
            Random rnd = new Random();
            Byte[] b = new Byte[3];
            rnd.NextBytes(b);
            Color color = Color.FromRgb(b[0], b[1], b[2]);
            return color;
        }
    }
}