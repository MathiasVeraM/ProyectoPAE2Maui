using Microsoft.Maui.Media;
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
                Title = "Seleccionar una imagen de la galería"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                MascotaImagen.Source = ImageSource.FromStream(() => stream);
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudo seleccionar la imagen: {ex.Message}", "OK");
        }
    }

    private async void GuardarPublicacionClicked(object sender, EventArgs e)
    {
        string raza = RazaEntry.Text;
        string sexo = SexoPicker.SelectedItem?.ToString();
        string edad = EdadEntry.Text;
        string peso = PesoEntry.Text;
        string tamaño = TamañoPicker.SelectedItem?.ToString();
        string esterilizacion = EsterilizacionPicker.SelectedItem?.ToString();
        string enfermedades = EnfermedadesEntry.Text;
        string descripcion = DescripcionEditor.Text;

        await DisplayAlert("Éxito", "Publicación creada exitosamente.", "OK");
    }
}