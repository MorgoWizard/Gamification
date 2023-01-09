using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OnMouseOverButtonChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Color defaultColor, selectedColor;
    [SerializeField] private Color defaultTextColor, selectedTextColor;
    
    private Image buttonImage;
    private TextMeshProUGUI buttonText;

    private void Start()
    {
        buttonImage = GetComponent<Image>();
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonImage.color = selectedColor;
        buttonText.color = selectedTextColor;
        //buttonText.fontStyle = FontStyles.Bold;
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonImage.color = defaultColor;
        buttonText.color = defaultTextColor;
        buttonText.fontStyle = FontStyles.Normal;
    }
}