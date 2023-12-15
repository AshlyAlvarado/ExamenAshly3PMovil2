using ExamenAshly3PMovil2.Views;

namespace ExamenAshly3PMovil2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Rutas de acceso 
            Routing.RegisterRoute(nameof(NuevaNotaPage), typeof(NuevaNotaPage));

        }
    }
}