using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    private const float Speed = 5f;

    private IPlayerInput _inputSystem;

    public void Initialize(IPlayerInput input)
    {
        _inputSystem = input;
        _inputSystem.MovedPlayer += Move;
    }

    private void Move(Vector2 direction)
    {
        transform.Translate(new Vector3(
            Speed * direction.x * Time.deltaTime,
            0f,
            Speed * direction.y * Time.deltaTime));


    }

}
