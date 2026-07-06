using System.Collections.ObjectModel;

namespace Frontend_Client.Views;

public class NotificationItem
{
    public string Name { get; set; }
    public string Message { get; set; }
    public string Initials { get; set; }
}

public partial class Client_Notification : ContentPage
{
    public Client_Notification()
    {
        InitializeComponent();
        LoadRaketRequests();
    }

    private void LoadRaketRequests()
    {
        // TODO: replace with real data from notificationService
        NotificationsList.ItemsSource = new ObservableCollection<NotificationItem>
        {
            new NotificationItem { Name = "Juan Dela Cruz", Message = "Has accepted your Raket Request", Initials = "JD" },
            new NotificationItem { Name = "Juan Dela Cruz", Message = "Has sent you a message", Initials = "JD" },
            new NotificationItem { Name = "Juan Dela Cruz", Message = "Has declined your Raket Request", Initials = "JD" },
        };
    }

    private void LoadMessages()
    {
        // TODO: replace with real data from notificationService
        NotificationsList.ItemsSource = new ObservableCollection<NotificationItem>
        {
            new NotificationItem { Name = "Juan Dela Cruz", Message = "Hi, I'll be there in 10 minutes.", Initials = "JD" },
        };
    }

    private async void BackButton_Tapped(object sender, TappedEventArgs e)
        => await Navigation.PopAsync();

    private void RaketRequestsTab_Tapped(object sender, TappedEventArgs e)
    {
        RaketRequestsTabBorder.BackgroundColor = Colors.White;
        RaketRequestsTabLabel.TextColor = Color.FromArgb("#1F1F1F");
        RaketRequestsTabLabel.FontAttributes = FontAttributes.Bold;

        MessagesTabBorder.BackgroundColor = Colors.Transparent;
        MessagesTabLabel.TextColor = Color.FromArgb("#8A8A8A");
        MessagesTabLabel.FontAttributes = FontAttributes.None;

        LoadRaketRequests();
    }

    private void MessagesTab_Tapped(object sender, TappedEventArgs e)
    {
        MessagesTabBorder.BackgroundColor = Colors.White;
        MessagesTabLabel.TextColor = Color.FromArgb("#1F1F1F");
        MessagesTabLabel.FontAttributes = FontAttributes.Bold;

        RaketRequestsTabBorder.BackgroundColor = Colors.Transparent;
        RaketRequestsTabLabel.TextColor = Color.FromArgb("#8A8A8A");
        RaketRequestsTabLabel.FontAttributes = FontAttributes.None;

        LoadMessages();
    }

    private void NotificationItem_Tapped(object sender, TappedEventArgs e)
    {
        // TODO: navigate based on notification type
    }

    private async void Home_Tapped(object sender, EventArgs e)
        => await Navigation.PushAsync(new Views.Client_Dashboard());
}