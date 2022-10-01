using System;

public interface IMainMenuView : IView
{
    event Action NewGameStarted;
    event Action SettingsPressed;
    event Action ExitPressed;
}
