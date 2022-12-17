using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float time;
    private static bool _isRunning;
    private static bool _isTimerRanOut;

    private static float _minutes, _seconds;
    private static float _staticTimeLimit;
    private static GameObject _thisGameObject;
    private void Awake()
    {
        if (!_thisGameObject)
        {
            _thisGameObject = gameObject;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(this);

        _minutes = Mathf.RoundToInt(time / 60);
        _seconds = Mathf.RoundToInt(time % 60);
    }
    private void FixedUpdate()
    {
        if (time < 0.3f)
        {
            time = 0;
            Debug.Log("Time is ran out");
            _isTimerRanOut = true;
            return;
        }

        if (_isRunning)
        {
            time -= Time.fixedDeltaTime;
            _minutes = Mathf.FloorToInt(time / 60);
            _seconds = Mathf.FloorToInt(time % 60);
        }
        
        timerText.text = $"{_minutes:00}:{_seconds:00}";
    }
    public static void StartTimer(bool isStart)
    {
        _isRunning = isStart;
    }
    public static void PauseTimer(bool isPause)
    {
        _isRunning = isPause;
    }
    public static bool IsTimerRunOut()
    {
        return _isTimerRanOut;
    }
}