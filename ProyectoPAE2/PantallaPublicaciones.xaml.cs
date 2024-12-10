using Microsoft.Maui.Media;
using ProyectoPAE2.Models;
using ProyectoPAE2.Repositories;
namespace ProyectoPAE2;

public partial class PantallaPublicaciones : ContentPage
{
    public PantallaPublicaciones()
    {
        InitializeComponent();
    }

    public async void SeleccionarImagenClicked(object sender, EventArgs e)
    {
        try
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Seleccionar una imagen de la galer�a"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                MascotaImagen.Source = ImageSource.FromStream(() => stream);
            }
        }
        catch (Exception)
        {
            await DisplayAlert("Error", "No se pudo seleccionar la imagen", "OK");
            throw;
        }
    }

    private async void GuardarPublicacionClicked(object sender, EventArgs e)
    {
        var publicacion = new Publicacion()
        {
            NombreMascota = NombreEntry.Text,
            Raza = RazaEntry.Text,
            Sexo = SexoPicker.SelectedItem?.ToString(),
            Edad = int.TryParse(EdadEntry.Text, out int edad) ? edad : 0,
            Peso = float.TryParse(PesoEntry.Text, out float peso) ? peso : 0,
            Tama�o = Tama�oPicker.SelectedItem?.ToString(),
            Esterilizacion = EsterilizacionPicker.SelectedItem?.ToString() == "S�",
            Enfermedades = EnfermedadesEntry.Text,
            Comportamiento = DescripcionEditor.Text
        };

        var repository = new PublicacionFileRepository();
        bool result = repository.CrearPublicacion(publicacion);

        if (result)
        {
            await DisplayAlert("�xito", "Publicaci�n creada exitosamente.", "OK");
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            await DisplayAlert("Error", "Ocurri� un error al guardar la publicaci�n.", "OK");
        }
        
    }
}