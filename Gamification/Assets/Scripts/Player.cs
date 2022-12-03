using UnityEngine;

public class Player : MonoBehaviour
{
    private int _score;

    public void WrongAnswer()
    {
        _score -= 5;
    }
    
    public void WrongAnswer(int count)
    {
        _score -= 5*count;
    }

    public int ReturnScore()
    {
        return _score;
    }
    

    private void Start()
    {
        _score = 100;
    }
}
