using UnityEngine;

public class Starter : MonoBehaviour
{
    private void Awake()
    {
        _ = GameManager.Instance.LoadMainMenu();
    }
}
