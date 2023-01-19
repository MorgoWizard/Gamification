using UnityEngine;

public class ScalerWithWheel : MonoBehaviour
{
    [SerializeField] private float minScale, maxScale;
    private float _currentScale;

    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = gameObject.GetComponent<RectTransform>();
        minScale = _rectTransform.lossyScale.x;
        _currentScale = minScale;
    }

    private void Update()
    {
        float wheelInput = Input.GetAxis("Mouse ScrollWheel");
        _currentScale += wheelInput;
        if (_currentScale > maxScale) _currentScale = maxScale;
        if (_currentScale < minScale) _currentScale = minScale;
        _rectTransform.localScale = new Vector2(_currentScale, _currentScale);
    }
}
