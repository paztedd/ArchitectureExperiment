using System;

public interface ISettingsView : IView
{
    event Action BackPressed;
    event Action<bool> TimerEnabled;

    void SetTimerIsShownSetting(bool isOn);
}
