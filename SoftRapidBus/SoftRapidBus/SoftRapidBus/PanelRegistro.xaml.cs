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
    public partial class PanelRegistro : ContentPage
    {
        public PanelRegistro()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entrar());
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}