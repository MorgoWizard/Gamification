using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;

public class OnMouseOverUp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Vector3 originalPosition, targetPosition;
    private RectTransform _rectTransform;
    
    private float timer = 0;
    [SerializeField] float LerpTimer;
    [SerializeField] float Speed = 1;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        _rectTransform.position = Vector3.Lerp(_rectTransform.position, targetPosition, LerpTimer * Speed);
        LerpTimer = 0;
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        _rectTransform.position = Vector3.Lerp(_rectTransform.position, targetPosition, LerpTimer * Speed);
        LerpTimer = 0;
    }
    
    private void Update()
    {
        LerpTimer += Time.deltaTime;
    }
}
