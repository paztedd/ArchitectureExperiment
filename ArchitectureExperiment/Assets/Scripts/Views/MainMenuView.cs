using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : BaseView, IMainMenuView
{
    public event Action NewGameStarted;
    public event Action SettingsPressed;
    public event Action ExitPressed;

    [SerializeField] private Button NewGameButton;
    [SerializeField] private Button SettingsButton;
    [SerializeField] private Button ExitButton;

    private void Awake()
    {
        NewGameButton.onClick.AddListener(OnStartNewGamePress);
        SettingsButton.onClick.AddListener(OnSettingsPress);
        ExitButton.onClick.AddListener(OnExitPress);
    }

    private void OnDestroy()
    {
        NewGameButton.onClick.RemoveListener(OnStartNewGamePress);
        SettingsButton.onClick.RemoveListener(OnSettingsPress);
        ExitButton.onClick.RemoveListener(OnExitPress);
    }

    private void OnStartNewGamePress() => NewGameStarted?.Invoke();
    private void OnSettingsPress() => SettingsPressed?.Invoke();
    private void OnExitPress() => ExitPressed?.Invoke();
}
