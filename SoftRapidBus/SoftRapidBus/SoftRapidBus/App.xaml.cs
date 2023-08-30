using SoftRapidBus.DB;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoftRapidBus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            crearBD();

            MainPage = new NavigationPage(new MainPage());
        }
        public static DbContexto contexto { get; set; }
        private void crearBD()
        {
            var zona = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var ruta = System.IO.Path.Combine(zona, "Viajes");
            contexto = new DbContexto(ruta);

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
