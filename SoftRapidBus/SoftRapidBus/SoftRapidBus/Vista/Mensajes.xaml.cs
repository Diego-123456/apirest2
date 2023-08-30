using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoftRapidBus.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mensajes : ContentPage
    {
        public Mensajes()
        {
            InitializeComponent();
        }

        private async void btnEnvio_Clicked(object sender, EventArgs e)
        {
            await Sms.ComposeAsync(new SmsMessage(txtCelular.Text, txtMen.Text));
        }
    }
}