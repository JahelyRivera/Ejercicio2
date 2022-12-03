using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjemploClase2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            var atributo = new Models.Atributos
            {
                Nombres = TxtNombres.Text,
                Apellidos = TxtApellidos.Text,
                Edad = Convert.ToInt32(TxtEdad.Text),
                Correo = TxtCorreo.Text,
                EnviarNombre = TxtNombres.Text, 
                EnviarApellido = TxtApellidos.Text,
                EnviarEdad = Convert.ToInt32(TxtEdad.Text),
                EnviarCorreo = TxtCorreo.Text
            };

            var enviar = new Views.Enviar();
            enviar.BindingContext = atributo;
            await Navigation.PushModalAsync(enviar);
        }
    }
}
