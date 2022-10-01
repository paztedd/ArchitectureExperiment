using UnityEngine;

public interface IUIRoot
{
    Transform WorldspaceCanvas { get; }
    RectTransform OverlayCanvas { get; }
}
