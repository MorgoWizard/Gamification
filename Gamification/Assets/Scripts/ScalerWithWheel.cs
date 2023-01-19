using UnityEngine;

public class ScalerWithWheel : MonoBehaviour
{
    [SerializeField] private float minScale, maxScale;
    private float _currentScale;
    
    [SerializeField] private RectTransform contentContainer;
    [SerializeField] private float contentWidthMin, contentWidthMax, contentHeightMin, contentHeightMax;
    private float _currentContentWidth, _currentContentHeight;
    
    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = gameObject.GetComponent<RectTransform>();
        minScale = _rectTransform.lossyScale.x;
        _currentScale = minScale;
    }

    private void Update()
    {
        _currentContentWidth = contentWidthMin + (_currentScale - minScale) / (maxScale - minScale)* (contentWidthMax - contentWidthMin);
        _currentContentHeight = contentHeightMin + (_currentScale - minScale) / (maxScale - minScale) * (contentHeightMax - contentHeightMin);
        float wheelInput = Input.GetAxis("Mouse ScrollWheel");
        _currentScale += wheelInput;
        if (_currentScale > maxScale) _currentScale = maxScale;
        if (_currentScale < minScale) _currentScale = minScale;
        _rectTransform.localScale = new Vector2(_currentScale, _currentScale);
        contentContainer.sizeDelta = new Vector2(_currentContentWidth, _currentContentHeight);
    }
}
