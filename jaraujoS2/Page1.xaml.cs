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
    public partial class Page1 : ContentPage
    {
        public Page1(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO "+ usuario;
        }

        private void pcCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pcCiudades.SelectedIndex == -1) 
            {

                DisplayAlert("Alerta", "VALOR NULO", "Cerrar");
            }
            else 
            {
                DisplayAlert("Alerta", pcCiudades.Items[pcCiudades.SelectedIndex], "Cerrar");
            }

        }

        private void btnMostar_Clicked(object sender, EventArgs e)
        {
            string fecha = dpFechas.Date.ToString("M/d/yyyy");
            DisplayAlert("Alerta", "la fecha es" + fecha,"Cerrar") ;
        }
    }
}