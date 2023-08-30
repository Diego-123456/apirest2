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
    public partial class Listar_Servicios : ContentPage
    {
        public Listar_Servicios()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            load_servicios();

        }
        private async void load_servicios()
        {
            var reg_Servicios = await App.contexto.GetServicios();
            Listado.ItemsSource = reg_Servicios;
        }

        private async void BarraMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Registrar_Servicios());
        }

        private async void BtnEditar_Clicked(object sender, EventArgs e)
        {
            var elemento = (Servicio)(sender as MenuItem).CommandParameter;

            await Navigation.PushAsync(new Vista.Editar_Servicio(elemento));
        }

        private async void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Responder", "¿Desea eliminar?", "Si", "No"))
            {
                var elemento = (Servicio)(sender as MenuItem).CommandParameter;
                var nreg = await App.contexto.limpiar(elemento);
                if (nreg == 1)
                {
                    load_servicios();
                }
            }
        }
    }
}