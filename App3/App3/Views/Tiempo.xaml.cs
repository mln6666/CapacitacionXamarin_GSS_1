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
    public partial class Tiempo : ContentPage
    {
        public Tiempo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int v, d, t;
            v = int.Parse(entryVelocidad.Text);
            d = int.Parse(entryDistancia.Text);
            t = d/v;

            lblResultado.Text = t.ToString();
        }
    }
}