public interface IGameHUDView : IView
{
    void SetScore(int score);
    void SetHealth(int health);

    void StartTimer();
    void StopTimer();
    void ResetTimer();

    void EnableTimerPanel();
    void DisableTimerPanel();

}
