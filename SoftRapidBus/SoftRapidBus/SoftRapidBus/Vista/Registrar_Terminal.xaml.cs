using SoftRapidBus.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoftRapidBus.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrar_Terminal : ContentPage
    {
        public Registrar_Terminal()
        {
            InitializeComponent();
        }
        public Terminal ter { get; set; }

        private async void Barra_Clicked(object sender, EventArgs e)
        {
            try
            {
                var reg = new Terminal
                {
                    nom_ter = txtNom.Text,
                    dir_ter = txtDir.Text,
                    cel_ter = txtCel.Text

                };
                //Reg se envía al contexto llamando al método insertar
                var nreg = await App.contexto.ingresar(reg);
                if (nreg == 1)
                {
                    await Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }
    }
}