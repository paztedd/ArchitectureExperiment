using UnityEngine;

public interface IView 
{
    void SetRoot(Transform rootTransform);

    void Enable();
    void Disable();

    //UniTask Show();
    //UniTask Hide();

}
