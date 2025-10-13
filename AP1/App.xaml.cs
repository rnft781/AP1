using AP1.Vues;

namespace AP1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Register();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}