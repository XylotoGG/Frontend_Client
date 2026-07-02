using Frontend_Client.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Frontend_Client
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // TEMP: testing a specific page
            return new Window(new NavigationPage(new Client_Dashboard()));

            // ORIGINAL — restore before committing:
            // return new Window(new AppShell());
        }
    }
}