using System;
using UnityEngine;
using UnityEngine.UI;

public class SettingsView : BaseView, ISettingsView
{
    public event Action BackPressed;
    public event Action<bool> TimerEnabled;

    [SerializeField] private Button BackButton;
    [SerializeField] private Toggle TimerToggle;

    private void Awake()
    {
        BackButton.onClick.AddListener(OnBackButtonPressed);
        TimerToggle.onValueChanged.AddListener(OnTimerTogglePressed);
    }

    private void OnBackButtonPressed() => BackPressed?.Invoke();
    private void OnTimerTogglePressed(bool isOn) => TimerEnabled?.Invoke(isOn);

    public void SetTimerIsShownSetting(bool isOn)
    {
        TimerToggle.isOn = isOn;
    }
}
