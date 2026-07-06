namespace Frontend_Client.Views;

public partial class Client_Dashboard : ContentPage
{
    public Client_Dashboard()
    {
        InitializeComponent();
    }

    private async void BurgerButton_Clicked(object sender, EventArgs e)
    {
        BackdropOverlay.IsVisible = true;
        MenuPanel.IsVisible = true;
        await MenuPanel.TranslateTo(0, 0, 250, Easing.CubicOut);
    }

    private async void BackdropOverlay_Tapped(object sender, TappedEventArgs e)
    {
        await MenuPanel.TranslateTo(230, 0, 200, Easing.CubicIn);
        MenuPanel.IsVisible = false;
        BackdropOverlay.IsVisible = false;
    }

    private async void Notifications_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Views.Client_Notification());
    }

    private async void RaketeerCard_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Views.Client_RaketeerWhenClicked());
    }

    private async void MenuItem_Activity_Tapped(object sender, TappedEventArgs e)
    {
        //await Navigation.PushAsync(new Views.Client.ClientNotification());
    }

    private async void MenuItem_Profile_Tapped(object sender, TappedEventArgs e)
    {
        // await Navigation.PushAsync(new Views.Client.ClientProfile());
    }

    private async void MenuItem_MyRaketRequest_Tapped(object sender, TappedEventArgs e)
    {
        //await Navigation.PushAsync(new Views.Client.MyRaketRequests());
    }

    private async void MenuItem_SavedRaketeers_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Views.Client_SavedRaketeer());
    }

    private async void Logout_Tapped(object sender, TappedEventArgs e)
    {
        bool confirm = await DisplayAlert("Logout", "Are you sure you want to logout?", "Yes", "Cancel");
        if (confirm)
        {
            await Navigation.PopToRootAsync();
        }
    }
}