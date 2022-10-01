using UnityEngine;
using UnityEngine.UI;

public class GameHUDView : BaseView, IGameHUDView
{
    [SerializeField] private Text ScoreText;
    [SerializeField] private Text HealthText;
    [SerializeField] private Text TimerText;

    [SerializeField] private GameObject TimerPanel;

    private bool _isTimerStarted;
    private float _startTime;


    public void SetHealth(int health)
    {
        HealthText.text = health.ToString();
    }

    public void SetScore(int score)
    {
        ScoreText.text = score.ToString();
    }

    public void StartTimer()
    {
        _isTimerStarted = true;
        _startTime = Time.time;
    }

    public void StopTimer()
    {
        _isTimerStarted = false;
        _startTime = 0;
    }

    public void ResetTimer()
    {
        _isTimerStarted = false;
        _startTime = 0;
    }

    public void EnableTimerPanel()
    {
        TimerPanel.SetActive(true);
    }

    public void DisableTimerPanel()
    {
        TimerPanel.SetActive(false);
    }

    private void Update()
    {
        if (_isTimerStarted)
            TimerText.text = ((int)(Time.time - _startTime)).ToString();
    }

}
