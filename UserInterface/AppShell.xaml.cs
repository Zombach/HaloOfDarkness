﻿using UserInterface.Pages;

namespace UserInterface;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        Routing.RegisterRoute(nameof(GameBoardPage), typeof(GameBoardPage));
    }
}