using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance => _instance; 

    private static GameManager _instance;

    private IResourceManager _resourceManager;
    private ISystemResourceManager _systemResourceManager;
    private IInputManager _inputManager;
    private ISettingsManager _settingsManager;

    private IViewFactory _viewFactory;
    
    private IModel _currentModel;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            Initialize();
        }
    }

    //public async UniTask LoadGame<TGame>(int levelNumber) where TGame : IGameModel
    //{
    //    _currentModel?.Dispose();
    //    await SceneManager.LoadSceneAsync(EScenes.Game.GetName());
    //    InitializeScene();

    //    _currentModel = new GameModel(_resourceManager, _viewFactory, _inputManager, _settingsManager, levelNumber);
    //}


    public async UniTask LoadGame(int levelNumber)
    {
        _currentModel?.Dispose();
        await SceneManager.LoadSceneAsync(EScenes.Game.GetName());
        InitializeScene();

        _currentModel = new GameModel(_resourceManager, _viewFactory, _inputManager, _settingsManager, levelNumber);
    }

    public async UniTask LoadMainMenu(/*params if needed*/)
    {
        _currentModel?.Dispose();
        await SceneManager.LoadSceneAsync(EScenes.MainMenu.GetName());
        InitializeScene();

        _currentModel = new MainMenuModel(_resourceManager, _viewFactory, _settingsManager);
    }

    private void Initialize()
    {
        var resourceManager = gameObject.AddComponent<ResourceManager>();
        _resourceManager = resourceManager;
        _systemResourceManager = resourceManager;

        _settingsManager = new SettingsManager();

        _inputManager = gameObject.AddComponent<InputManager>();
    }

    private void InitializeScene()
    {
        // Create here UIRoot
        var mainCamera = _resourceManager.CreateMainCamera();
        var uiRoot = _resourceManager.CreateUIRoot(mainCamera);

        // Create here any UI factory
        var viewFactory = new ViewFactory(_systemResourceManager, uiRoot);
        _viewFactory = viewFactory;
    }
}
