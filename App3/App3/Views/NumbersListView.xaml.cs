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
    public partial class NumbersListView : ContentPage
    {
        public NumbersListView()
        {
            InitializeComponent();
        }

        private void new_ListView_Clicked(object sender, EventArgs e)
        {
            if (int.Parse(entryNumber.Text) == 0 & int.Parse(entryNumber.Text) > 25)
            {
                DisplayAlert("Aviso", "Debe ingresar un número dentro del rango 1-25", "OK");

            }
            else
            {
                numbersListView.BackgroundColor = RandomColor();
                var list_number= new  List<string>();
                for (int i = 1; i <= int.Parse(entryNumber.Text); i++)
                {
                    list_number.Add(i.ToString());
                }

                numbersListView.ItemsSource = list_number;
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