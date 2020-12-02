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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            if (entryUsuario.Text == "mponce" && entryPassword.Text == "goya12345")
            {
                DisplayAlert("Iniciar Sesión", "EXITO", "OK");
            }else
            {
                DisplayAlert("Iniciar Sesión", "ERROR", "OK");
            }

            //throw new NotImplementedException();
        }
    }
}