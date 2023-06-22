using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jaraujoS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid : ContentPage
    {
        public Grid()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = "jaraujo";
            string contrasena = "1234";
            if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
            {
                Navigation.PushAsync(new Page1(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contrasena Incorrectos", "Cerrar");
            }

        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new register());
        }
    }
}