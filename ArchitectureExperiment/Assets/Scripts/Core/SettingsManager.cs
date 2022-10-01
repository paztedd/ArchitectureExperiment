using UnityEngine;

public class SettingsManager : ISettingsManager
{
    public bool ShowTimerInGame 
    {
        get => bool.Parse(PlayerPrefs.GetString(ESettings.ShowTimerInGame.GetName(), true.ToString()));
        set => PlayerPrefs.SetString(ESettings.ShowTimerInGame.GetName(), value.ToString()); 
    }
}
