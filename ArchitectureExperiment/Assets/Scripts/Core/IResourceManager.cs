using UnityEngine;

public interface IResourceManager
{
    public Camera CreateMainCamera();
    public IPlayer CreatePlayer(IPlayerInput playerInput);
    public IUIRoot CreateUIRoot(Camera worldspaceCamera);


}