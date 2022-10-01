using UnityEngine;

public class BaseView : MonoBehaviour, IView
{
    public void SetRoot(Transform rootTransform)
    {
        transform.SetParent(rootTransform, false);
    }

    public virtual void Enable()
    {
        gameObject.SetActive(true);
    }

    public virtual void Disable()
    {
        gameObject.SetActive(false);
    }


}
