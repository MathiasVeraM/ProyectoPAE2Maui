namespace ProyectoPAE2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            GoToAsync("//PantallaLogin");
        }

        public async Task ShowMainPageAsync()
        {
            CurrentItem = MainTabBar;
            MainTabBar.IsVisible = true;

            await GoToAsync("//MainPage");
        }
    }
}
