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
    public partial class PresentacionPage : ContentPage
    {
        public PresentacionPage()
        {
            InitializeComponent();
        }

        private async void btnMensaje_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mensajes());
        }
    }
}