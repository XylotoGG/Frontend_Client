using Microsoft.Maui.Controls;

namespace Frontend_Client
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Home";
            Content = new Grid
            {
                Padding = 20,
                Children =
                {
                    new Label { Text = "Main Page", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center }
                }
            };
        }
    }
}
