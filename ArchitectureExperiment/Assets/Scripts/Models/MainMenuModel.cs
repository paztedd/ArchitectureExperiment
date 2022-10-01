using System;

public class MainMenuModel : BaseModel
{
    private IResourceManager _resourceManager;
    private ISettingsManager _settingsManager;

    private IMainMenuView _view;
    private ISettingsView _settingsView;

    public MainMenuModel(IResourceManager resourcemanager, IViewFactory viewFactory, ISettingsManager settingsManager)
    {
        _resourceManager = resourcemanager;
        _settingsManager = settingsManager;

        _view = viewFactory.CreateView<IMainMenuView>(EViews.MainMenuView);

        _view.NewGameStarted += StartGame;
        _view.SettingsPressed += ShowSettings;
        _view.Enable();

        _settingsView = viewFactory.CreateView<ISettingsView>(EViews.SettingsView);
        _settingsView.BackPressed += ShowMainMenu;
        _settingsView.TimerEnabled += SaveTimerSettings;
        _settingsView.Disable();
    }

    public override void Dispose()
    {
        _view.NewGameStarted -= StartGame;
    }

    private void StartGame()
    {
        _ = GameManager.Instance.LoadGame(123);
    }

    private void ShowSettings()
    {
        _view.Disable();
        _settingsView.SetTimerIsShownSetting(_settingsManager.ShowTimerInGame);
        _settingsView.Enable();
    }

    private void ShowMainMenu()
    {
        _settingsView.Disable();
        _view.Enable();
    }

    private void SaveTimerSettings(bool isTimerShown)
    {
        _settingsManager.ShowTimerInGame = isTimerShown;
    }

}
