using System;

public enum ESettings
{
    ShowTimerInGame,

}

public static class ESettingsExtension
{
    public static string GetName(this ESettings scene) => Enum.GetName(typeof(ESettings), scene);
}