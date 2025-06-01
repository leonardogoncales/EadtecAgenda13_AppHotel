using AppHotel.Views;

namespace AppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new NavigationPage(new Views.ContratacaoHospedagem());

            MainPage = new Sobre();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 375;
            window.Height = 800;

            return window;
        }
    }
}
