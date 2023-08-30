using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoftRapidBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void btnTerminales_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Listar_Terminales());
        }

        private async void btnPresentación_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.PresentacionPage());
        }

        private async void btnTipos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Listar_Servicios());
        }
    }
}