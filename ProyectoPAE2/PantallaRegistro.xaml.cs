using ProyectoPAE2.Interfaces;
using ProyectoPAE2.Models;
using ProyectoPAE2.Repositories;
using System.IO;
using Microsoft.Maui.Controls;

namespace ProyectoPAE2;

public partial class PantallaRegistro : ContentPage
{
	public IUsuarioRepository _usuarioRepository;
	public Usuario usuario = new Usuario();

    public PantallaRegistro()
	{
		InitializeComponent();
		_usuarioRepository = new UsuarioFilesRepository();
		usuario = _usuarioRepository.DevuelveInfoUsuario(1);
		BindingContext = usuario;
	}

    private async void BotonRegistrarse_Clicked(object sender, EventArgs e)
    {
		Usuario usuario = new Usuario()
		{
			Nombre = editor_nombre.Text,
			Correo = editor_Correo.Text,
			Clave = editor_Clave.Text
		};

		bool guardar = _usuarioRepository.CrearUsuario(usuario);

		if (guardar)
		{
			await DisplayAlert("Guardado correctamente", "OK");
		}
    }
}