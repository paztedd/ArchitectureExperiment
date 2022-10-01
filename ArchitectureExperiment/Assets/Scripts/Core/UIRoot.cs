using UnityEngine;

public class UIRoot : MonoBehaviour, IUIRoot
{
    [SerializeField] private Transform WorldspaceCanvasTransform;
    [SerializeField] private RectTransform OverlayCanvasTransform;

    public Transform WorldspaceCanvas => WorldspaceCanvasTransform;

    public RectTransform OverlayCanvas => OverlayCanvasTransform;

    public void Initialize(Camera mainCamera)
    {
        var worldCanvas = WorldspaceCanvas.GetComponent<Canvas>();
        worldCanvas.worldCamera = mainCamera;
    }    

}
