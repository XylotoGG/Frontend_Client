using Microsoft.Maui.Controls;

namespace Frontend_Client.Views.Client
{
    public class ClientNotification : ContentPage
    {
        public ClientNotification()
        {
            Title = "Notifications";
            Content = new Label { Text = "Client Notifications", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
        }
    }
}
