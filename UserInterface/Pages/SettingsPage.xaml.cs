using System.Diagnostics;
using UserInterface.ViewModel;

namespace UserInterface.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingsViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    void OnLanguageRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton button = sender as RadioButton;
        LanguageStateLabel.Text = $"You have chosen: {button.Content}";
    }

    void OnSoundSwitchButtonToggled(object sender, ToggledEventArgs e)
    {
        string stateName = e.Value ? "On" : "Off";
        SoundStateLabel.Text = $"{stateName}";
    }

    void OnNotificationsCheckBoxChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            NotificationsStateLabel.Text = $"On";
        }
        else
        {
            NotificationsStateLabel.Text = $"Off";
        }
    }

    void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
        int value = (int)Math.Round(args.NewValue);
        displayLabel.Text = String.Format("The Slider value is {0}", value);
    }

    async void CloseApplication(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
        Debug.WriteLine("Answer: " + answer);
        if (answer)
        {
            App.Current.Quit();
        }
    }
}