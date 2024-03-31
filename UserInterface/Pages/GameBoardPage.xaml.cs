using CommunityToolkit.Maui.Views;

namespace UserInterface.Pages;

public partial class GameBoardPage : ContentPage
{
    public GameBoardPage()
    {
        InitializeComponent();
    }

    async void GoToPopupMenuPage(object sender, EventArgs e)
    {
        await this.ShowPopupAsync(new PopupMenuPage());
    }
}