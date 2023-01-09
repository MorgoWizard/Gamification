using System;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnMouseOverInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [CanBeNull][SerializeField] private string Title;
    [CanBeNull][SerializeField] private string Description;
    
    [SerializeField] private RectTransform informationWindow;
    public static Action<string, string> SetTexts;
    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        informationWindow.gameObject.SetActive(true);
        SetTexts?.Invoke(Title,Description);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //canMoveWindow = false;
        informationWindow.gameObject.SetActive(false);
    }

    private void Update()
    {
        //if(!canMoveWindow)
            //return;
        var mousePos = Input.mousePosition;
        var size = informationWindow.sizeDelta;
        
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, mousePos,
            canvas.worldCamera, out var movePos);
        
        float upOrDown, leftOrRight = mousePos.x < Screen.width * 0.5f ? 1f : -1f;
        
        if (mousePos.y > Screen.height * 0.66f)
            upOrDown = -1f;
        else if (mousePos.y < Screen.height * 0.33f)
            upOrDown = 1f;
        else
            upOrDown = 0f;
        
        movePos = new Vector2(movePos.x + leftOrRight * size.x*0.55f, movePos.y + upOrDown * size.y*0.55f);
        informationWindow.transform.position = canvas.transform.TransformPoint(movePos);
    }
}
