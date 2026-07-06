namespace Frontend_Client.Views;

public partial class Client_SavedRaketeer : ContentPage
{
    public Client_SavedRaketeer()
    {
        InitializeComponent();
        // TODO: SavedList.ItemsSource = await savedRaketeersService.GetSavedAsync();
    }

    private async void BackButton_Tapped(object sender, TappedEventArgs e)
        => await Navigation.PopAsync();

    //private async void SavedItem_Tapped(object sender, TappedEventArgs e)
       // => await Navigation.PushAsync(new RaketeerDetail());

       private async void Notifications_Tapped(object sender, TappedEventArgs e)
       {
           await Navigation.PushAsync(new Client_Notification());
       }

    private async void Home_Tapped(object sender, EventArgs e)
        => await Navigation.PushAsync(new Client_Dashboard());
}