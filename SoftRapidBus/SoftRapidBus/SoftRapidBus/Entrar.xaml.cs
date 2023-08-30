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
    public partial class Entrar : ContentPage
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PanelRegistro());
        }
    }
}