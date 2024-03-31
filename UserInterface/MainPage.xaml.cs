using UserInterface.Pages;

namespace UserInterface;

public partial class MainPage : ContentPage
{
    public MainPage() => InitializeComponent();

    async void GoToSettingsPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }

    async void GoToGameBoardPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(GameBoardPage));
    }
}