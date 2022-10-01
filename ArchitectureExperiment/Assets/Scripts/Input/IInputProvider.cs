using UnityEngine;

public interface IRawInputProvider
{
    void DirectionChangeInvoked(Vector2 direction);
}

public interface IInputProvider
{
    void Pause();
    void Continue();
}