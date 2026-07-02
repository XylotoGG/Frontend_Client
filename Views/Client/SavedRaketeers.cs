using Microsoft.Maui.Controls;

namespace Frontend_Client.Views.Client
{
    public class SavedRaketeers : ContentPage
    {
        public SavedRaketeers()
        {
            Title = "Saved Raketeers";
            Content = new Label { Text = "Saved Raketeers", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
        }
    }
}
