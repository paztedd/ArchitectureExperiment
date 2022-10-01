using UnityEngine;

public class BaseInput : IRawInputProvider, IInputProvider
{
    private bool _isPaused = false;

    public virtual void DirectionChangeInvoked(Vector2 direction) { }

    public void Pause() => _isPaused = true;

    public void Continue() => _isPaused = false;
}