using System;
using UnityEngine;


public interface IPlayerInput : IRawInputProvider, IInputProvider
{
    event Action<Vector2> MovedPlayer;
}