using UnityEngine;

public class HelpApDis : MonoBehaviour
{
    private bool _isOpen;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void ChangeState()
    {
        if (_isOpen)
        {
            _isOpen = !_isOpen;
            _animator.Play("Disappear");
        }
        else
        {
            _isOpen = !_isOpen;
            _animator.Play("Appear");
        }
    }
}
