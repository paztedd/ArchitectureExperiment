using UnityEngine;

public class ResourceManager : MonoBehaviour, IResourceManager, ISystemResourceManager
{
    private const string _prefabsPath = "Prefabs/";

    public Camera CreateMainCamera()
    {
        return Instantiate(Resources.Load<Camera>(_prefabsPath + "Components/MainCamera"));
    }

    public IUIRoot CreateUIRoot(Camera worldspaceCamera)
    {
        var uiRoot = Instantiate(Resources.Load<UIRoot>(_prefabsPath + "Components/UIRoot"));
        uiRoot.Initialize(worldspaceCamera);

        return uiRoot;
    }

    public IPlayer CreatePlayer(IPlayerInput playerInput)
    {
        var playerPrefab = Resources.Load<Player>(_prefabsPath + "Game/Player");
        var player = Instantiate(playerPrefab);
        player.Initialize(playerInput);
        
        return player;
    }

    //public IEnemy CreateEnemy(EEnemy enemy)
    //{
    //    return Resources.Load<Player>(_prefabsPath + "Game/Enemies/" + enemy.GetName());
    //}

    public T CreateObject<T>(string path)
    {
        var obj = Instantiate(Resources.Load<GameObject>(_prefabsPath + path));
        // TODO: error handling
        return obj.GetComponent<T>();
    }

}
