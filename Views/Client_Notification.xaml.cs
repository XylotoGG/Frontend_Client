using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend_Client.Views;

public partial class Client_Notification : ContentPage
{
    public Client_Notification()
    {
        InitializeComponent();
    }
    
    private async void BackButton_Tapped(object sender, TappedEventArgs e)
        => await Navigation.PopAsync();

    private void ActivityTab_Tapped(object sender, TappedEventArgs e)
    {
        ActivityTabLabel.TextColor = Color.FromArgb("#1B4D3E");
        MessagesTabLabel.TextColor = Color.FromArgb("#8A8A8A");
        // TODO: NotificationsList.ItemsSource = activity items
    }

    private void MessagesTab_Tapped(object sender, TappedEventArgs e)
    {
        MessagesTabLabel.TextColor = Color.FromArgb("#1B4D3E");
        ActivityTabLabel.TextColor = Color.FromArgb("#8A8A8A");
        // TODO: NotificationsList.ItemsSource = message items
    }

    private void NotificationItem_Tapped(object sender, TappedEventArgs e)
    {
        // TODO: navigate based on notification type
    }
}