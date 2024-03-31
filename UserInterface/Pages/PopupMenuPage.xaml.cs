using CommunityToolkit.Maui.Views;

using System.Diagnostics;

namespace UserInterface.Pages;

public partial class PopupMenuPage : Popup
{
    public PopupMenuPage()
    {
        InitializeComponent();
    }

    async void GoToContinue(object sender, EventArgs e)
    {
        await CloseAsync();
    }

    async void GoToSettingsPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
        await CloseAsync();
    }

    async void GoToMainPage(object sender, EventArgs e)
    {
        bool answer = await Shell.Current.DisplayAlert("Question?", "The game will end when. Are you sure?", "Yes", "No");
        Debug.WriteLine("Answer: " + answer);
        if (answer)
        {
            await CloseAsync();
            await Shell.Current.GoToAsync("..", true);
        }
    }
}