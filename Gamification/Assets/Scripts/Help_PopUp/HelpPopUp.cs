using System;
using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class HelpPopUp : MonoBehaviour
{
    [Serializable]
    public struct Descriptions
    {
        public string locationName;
        public string description;
    }

    [SerializeField] private Descriptions[] _descriptions;

    [SerializeField] private TextMeshProUGUI _descriptionText;

    private RectTransform _rectTransform;

    private bool _isOpen = false;
    private bool _isPlayingAnimate = false;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void SwitchDescription(TextMeshProUGUI locationName)
    {
        if (_descriptions == null)
            return;

        for (int i = 0; i < _descriptions.Length; i++)
        {
            if (_descriptions[i].locationName == locationName.text)
                _descriptionText.text = _descriptions[i].description;
        }
    }

    private IEnumerator SmoothAnimation(Vector3 endPoint, float speed = 1f)
    {
        _isPlayingAnimate = true;

        Vector3 startPoint = _rectTransform.localPosition;
        float time = 0f;

        while (_rectTransform.localPosition != endPoint)
        {
            time += Time.deltaTime * speed;
            _rectTransform.localPosition = Vector3.Lerp(startPoint, endPoint, time);

            yield return new WaitForSeconds(0f);
        }

        _isPlayingAnimate = false;
    }

    public void SwitchPopUp()
    {
        if (_isPlayingAnimate)
            return;

        if (!_isOpen)
            StartCoroutine(SmoothAnimation(new Vector3(0f + Screen.width / 2f, 0f, 0f)));
        else
            StartCoroutine(SmoothAnimation(new Vector3(500f + Screen.width / 2f, 0f, 0f)));

        _isOpen = !_isOpen;
    }
}
