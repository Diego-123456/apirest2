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
    public partial class Registrar_Servicios : ContentPage
    {
        public Registrar_Servicios()
        {
            InitializeComponent();
        }
        public Servicio Ser { get; set; }
        private async void Barra_Clicked(object sender, EventArgs e)
        {
            try
            {
                var reg = new Servicio
                {
                    nom_Ser = txtNom.Text,
                    Precio_Ser = txtPrecio.Text,
                    Num_Ser = txtNum.Text

                };
                //Reg se envía al contexto llamando al método insertar
                var nreg = await App.contexto.insertarData(reg);
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