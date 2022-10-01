using System;

public enum EViews 
{
    MainMenuView,
    SettingsView,
    GameHUDView,
    GameOverView,
    //Pause
}

public static class EViewsExtension
{
    public static string GetName(this EViews view) => Enum.GetName(typeof(EViews), view);
}