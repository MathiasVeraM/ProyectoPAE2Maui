using ProyectoPAE2.Repositories;

namespace ProyectoPAE2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            var repository = new PublicacionFileRepository();
            var publicaciones = repository.DevuelveInfoPublicacion(1);

            PublicacionesCollectionView.ItemsSource = (System.Collections.IEnumerable)publicaciones;
        }
        private async void NuevaPublicacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantallaPublicaciones());
        }
    }

}
