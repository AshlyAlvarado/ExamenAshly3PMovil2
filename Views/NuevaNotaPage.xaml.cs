using Firebase.Database;
using Firebase.Database.Query;
using ExamenAshly3PMovil2.Models;

namespace ExamenAshly3PMovil2.Views;

public partial class NuevaNotaPage : ContentPage
{
    FirebaseClient client = new FirebaseClient("https://examenashlymovil2-default-rtdb.firebaseio.com/");

        public List<Notas> ID {  get; set; }


    public NuevaNotaPage()
	{
		InitializeComponent();
	}

    private async void B_Ver_Clicked(object sender, EventArgs e)
    {
		await client.Child("Notas").PostAsync(new Notas
		{
            IdNotas = int.Parse(IdEntry.ToString()),
            Descripcion = DescripcionEntry.Text,
            Fecha = fechaInicioPicker.Date.ToOADate(),
            AudioRecord = 0,
			PhotoRecord = 0
		});
		await Shell.Current.GoToAsync("..");
			
        }

    }