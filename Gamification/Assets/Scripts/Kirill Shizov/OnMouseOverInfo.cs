using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnMouseOverInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RawImage parentImage;
    [SerializeField] private GameObject informationWindow;

    private void Awake()
    {
        parentImage = GetComponentInParent<RawImage>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        parentImage.enabled = true;
        informationWindow.SetActive(true);
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        parentImage.enabled = false;
        informationWindow.SetActive(false);
    }
}
