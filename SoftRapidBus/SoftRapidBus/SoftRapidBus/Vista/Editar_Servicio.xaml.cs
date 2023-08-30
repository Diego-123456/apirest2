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
    public partial class Editar_Servicio : ContentPage
    {
        public Editar_Servicio()
        {
            InitializeComponent();
        }
        public Editar_Servicio(Servicio Ser)
        {
            InitializeComponent();
            txtId.Text = Ser.id_Ser.ToString();
            txtNom.Text = Ser.nom_Ser;
            txtPrecio.Text = Ser.Precio_Ser;
            txtNum.Text = Ser.Num_Ser;
        }

        private async void BtnModi_Clicked(object sender, EventArgs e)
        {
            try
            {
                var reg = new Servicio
                {
                    id_Ser = Convert.ToInt32(txtId.Text),
                    nom_Ser = txtNom.Text,
                    Precio_Ser = txtPrecio.Text,
                    Num_Ser = txtNum.Text

                };
                //Reg se envía al contexto llamando al método insertar
                var nreg = await App.contexto.modificar(reg);
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