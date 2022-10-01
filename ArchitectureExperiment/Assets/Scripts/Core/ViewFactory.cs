using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewFactory : IViewFactory
{
    private const string UIPrefabPath = "UI/";

    private ISystemResourceManager _resourceManager;
    private IUIRoot _UIRoot;

    public ViewFactory(ISystemResourceManager resourceManager, IUIRoot uiRoot)
    {
        _resourceManager = resourceManager;
        _UIRoot = uiRoot;
    }

    public T CreateView<T>(EViews view) where T : IView
    {
        var viewObj = _resourceManager.CreateObject<T>(UIPrefabPath + view.GetName());
        viewObj.SetRoot(_UIRoot.OverlayCanvas);

        return viewObj;
    }

}
