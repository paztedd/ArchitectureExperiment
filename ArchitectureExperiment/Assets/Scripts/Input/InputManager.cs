using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour, IInputManager
{
    private Vector2 _direction = Vector2.zero;

    private List<IRawInputProvider> _providers = new List<IRawInputProvider>();

    public void Subscribe(IRawInputProvider provider) => _providers.Add(provider);

    public void Unsubscribe(IRawInputProvider provider) => _providers.Remove(provider);

    private void Update()
    {
        CheckAxisDirection();
    }

    private void CheckAxisDirection()
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.y = Input.GetAxisRaw("Vertical");

        foreach (var provider in _providers) 
        { 
            provider.DirectionChangeInvoked(_direction); 
        }
    }
}