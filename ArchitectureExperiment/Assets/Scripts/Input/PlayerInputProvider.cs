using System;
using UnityEngine;


public class PlayerInputProvider : BaseInput, IPlayerInput
{
    public event Action<Vector2> MovedPlayer;

    private bool _isPaused = false;


    public override void DirectionChangeInvoked(Vector2 direction)
    {
        if (!_isPaused)
        {
            MovedPlayer?.Invoke(direction);
        }
    }

}