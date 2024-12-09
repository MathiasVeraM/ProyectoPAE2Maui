
namespace ProyectoPAE2;

public partial class PantallaLogin : ContentPage
{
	public PantallaLogin()
	{
		InitializeComponent();
	}

	private async void OnRegisterTapped(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new PantallaRegistro());
    }
}
