using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : BaseModel
{
    private IResourceManager _resourceManager;

    public GameModel(IResourceManager resourceManager, IViewFactory viewFactory, 
        IInputManager inputManager, ISettingsManager settingsManager, int levelNumber)
    {
        _resourceManager = resourceManager;

        var playerInput = new PlayerInputProvider();
        inputManager.Subscribe(playerInput);

        var player = _resourceManager.CreatePlayer(playerInput);

        var hud = viewFactory.CreateView<IGameHUDView>(EViews.GameHUDView);
        hud.Enable();

        hud.SetHealth(100);
        hud.SetScore(0);
        hud.StartTimer();

        var showTimer = settingsManager.ShowTimerInGame;
        if (showTimer)
            hud.EnableTimerPanel();
        else
            hud.DisableTimerPanel();
    }


}