using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Repaso.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro( string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Bienvenido " + usuario;
        }

        private void bntCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                double valor = precio * cantidad;

                DisplayAlert("Valor total del producto", valor.ToString(), "Cerrar");
            }
            catch(Exception ex) {

                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }

        }
    }
}