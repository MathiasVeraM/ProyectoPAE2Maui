
using ProyectoPAE2.Models;
using ProyectoPAE2.Repositories;

namespace ProyectoPAE2;

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
            Usuario usuario = _usuarioRepository.BuscarUsuarioPorCorreoYClave(correo, clave);

            if (usuario == null)
            {
                await DisplayAlert("Error", "La clave o correo son incorrectos", "OK");
                return;
            }

            await Navigation.PushAsync(new MainPage());
        }
        catch (Exception)
        {
            throw;
        }
    }
}
