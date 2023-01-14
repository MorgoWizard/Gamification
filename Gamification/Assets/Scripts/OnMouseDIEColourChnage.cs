using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class OnMouseDIEColourChnage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image windowImage;
    [SerializeField] private Color selectedColor, deselectedColor;

    private void Start()
    {
        windowImage = GetComponent<Image>();
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        windowImage.color = selectedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(tag != "SelectedButton")
            windowImage.color = deselectedColor;
    }

    public void ButtonGotUnselected()
    {
        if(tag != "SelectedButton")
            windowImage.color = deselectedColor;
    }

    public void ButtonGotSelected()
    {
        windowImage.color = selectedColor;
        
        GameObject [] otherButtons;
        otherButtons = GameObject.FindGameObjectsWithTag("UnSelectedButton");

        foreach (var images in otherButtons)
        {
            images.GetComponent<OnMouseDIEColourChnage>().ButtonGotUnselected();
        }
    }
}
