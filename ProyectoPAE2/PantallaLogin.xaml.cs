using ProyectoPAE2;
using ProyectoPAE2.Models;
using ProyectoPAE2.Repositories;

public partial class PantallaLogin : ContentPage
{
    private UsuarioFilesRepository _usuarioRepository;
    public PantallaLogin()
    {
        InitializeComponent();
        _usuarioRepository = new UsuarioFilesRepository();
    }

    private async void OnRegisterTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PantallaRegistro());
    }

    private async void BotonLogin_Clicked(object sender, EventArgs e)
    {
        string correo = editor_correo.Text;
        string clave = editor_contraseña.Text;

        if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave))
        {
            await DisplayAlert("Error", "Deben ingresarse datos para iniciar sesión", "OK");
            return;
        }

        try
        {
            Usuario usuario = _usuarioRepository.DevuelveInfoUsuario(1);

            if (usuario == null)
            {
                await DisplayAlert("Error", "No se encontró ningún usuario registrado.", "OK");
                return;
            }

            if (usuario.Correo == correo && usuario.Clave == clave)
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Error", "La clave o correo son incorrectos", "OK");
                return;
            }

        }
        catch (Exception)
        {
            throw;
        }

    }
}
