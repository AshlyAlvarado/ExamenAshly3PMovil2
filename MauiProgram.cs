using Microsoft.Extensions.Logging;
using Firebase.Database;
using Firebase.Database.Query;
using ExamenAshly3PMovil2.Models;


namespace ExamenAshly3PMovil2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            Registrar();


            return builder.Build();
        }
        public static void Registrar()
        {

            FirebaseClient client = new FirebaseClient("https://examenashlymovil2-default-rtdb.firebaseio.com/");
            var primeraNota = client.Child("Notas").OnceAsync<Notas>();
            if (primeraNota.Result.Count == 0)
            {
                client.Child("Notas").PostAsync(new Notas { IdNotas = 1, Descripcion = "Primera nota de prueba", Fecha = 15 / 12 / 23, AudioRecord = 0, PhotoRecord = 0 });


            }
        }
    }
}