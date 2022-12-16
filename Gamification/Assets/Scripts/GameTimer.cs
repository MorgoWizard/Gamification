using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private float _timeLimit = 40;
    private static bool _isRunning = false;
    private static bool _isTimerRanOut = false;

    private static float _minutes, _seconds, _time;
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

        _time = _timeLimit * 60;

        _minutes = Mathf.RoundToInt(_time / 60);
        _seconds = Mathf.RoundToInt(_time % 60);

        _staticTimeLimit = _timeLimit;
    }
    private void FixedUpdate()
    {
        if (_time < 0.01f)
        {
            _time = 0;
            Debug.Log("Time is ran out");
            _isTimerRanOut = true;
            return;
        }

        if (_time > 60)
            _timerText.text = "Осталось " + _minutes + " м " + _seconds + " c";
        else
            _timerText.text = "Осталось " + _seconds + " с";

        if (_isRunning)
        {
            _time -= Time.fixedDeltaTime;
            _minutes = Mathf.RoundToInt(_time / 60);
            _seconds = Mathf.RoundToInt(_time % 60);
        }
    }
    public static void StartTimer(bool isStart)
    {
        _isRunning = isStart;
    }
    public static void PauseTimer(bool isPause)
    {
        _isRunning = isPause;
    }
    public static void ResetTimer()
    {
        _time = _staticTimeLimit * 60;
        _isTimerRanOut = false;
    }
    public static bool IsTimerRunOut()
    {
        return _isTimerRanOut;
    }
}