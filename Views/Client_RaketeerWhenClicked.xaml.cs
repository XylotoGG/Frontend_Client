namespace Frontend_Client.Views;

public partial class Client_RaketeerWhenClicked : ContentPage
{
	public Client_RaketeerWhenClicked()
	{
		InitializeComponent();
	}

    private async void BackButton_Tapped(object sender, TappedEventArgs e)
        => await Navigation.PopAsync();

    private async void Home_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Views.Client_Dashboard());
    }
    
    private async void Notifications_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Views.Client_Notification());
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        // TODO: call SavedRaketeersService to add this raketeer to saved list
    }

    private async void RaketRequestButton_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new FillUpRaketRequest());
    }
}