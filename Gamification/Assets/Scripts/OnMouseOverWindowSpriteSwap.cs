using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OnMouseOverWindowSpriteSwap : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image windowImage;
    [SerializeField] private Sprite selectedImage, deselectedImage;

    private void Start()
    {
        windowImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        windowImage.overrideSprite = selectedImage;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(tag != "SelectedButton")
            windowImage.overrideSprite = deselectedImage;
    }

    public void ButtonGotUnselected()
    {
        if(tag != "SelectedButton")
            windowImage.overrideSprite = deselectedImage;
    }

    public void ButtonGotSelected()
    {
        windowImage.overrideSprite = selectedImage;
        
        GameObject [] otherButtons;
        otherButtons = GameObject.FindGameObjectsWithTag("UnSelectedButton");

        foreach (var images in otherButtons)
        {
            images.GetComponent<OnMouseOverWindowSpriteSwap>().ButtonGotUnselected();
        }
    }
}
