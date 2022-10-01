using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EScenes 
{
    MainMenu,
    Game
}

public enum EGameLevels
{

    ShooterGame1,
    ShooterGame2,
    SlasherGame
}

public static class EScenesExtension
{
    public static string GetName(this EScenes scene) => Enum.GetName(typeof(EScenes), scene);
    //public static Type GetModel(this EScenes scene)
    //{
    //    switch (scene)
    //    {
    //        case EScenes.MainMenu:
    //            return typeof(MainMenuModel);

    //        case EScenes.Game:
    //            return typeof(GameModel);

    //        default:
    //            break;
    //    }
    //}
}