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
    public partial class Listar_Terminales : ContentPage
    {
        public Listar_Terminales()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        { 
            load_terminales();
        }
        private async void load_terminales()
        {
            var reg_terminales = await App.contexto.GetTerminales();
            Listado.ItemsSource = reg_terminales;
        }
        private async void BarraMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Registrar_Terminal());
        }

        private async void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Responder", "¿Desea eliminar?", "Si", "No"))
            {
                var elemento = (Terminal)(sender as MenuItem).CommandParameter;
                var nreg = await App.contexto.eliminar(elemento);
                if (nreg == 1)
                {
                    load_terminales();
                }
            }
        }
    }
}