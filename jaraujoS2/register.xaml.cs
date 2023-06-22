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
    public partial class register : ContentPage
    {
        public register()
        {
            InitializeComponent();
        }

        private void pcEdades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (pcEdades.SelectedIndex == -1)
            {
                DisplayAlert("Alerta", "VALOR NULO", "Cerrar");
            }
            else
            {
                DisplayAlert("ALERT " , "Usuario Creado " + nombre + " tienes " + pcEdades.Items[pcEdades.SelectedIndex], "Cerrar");
            }
        }
    }
}