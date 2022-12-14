using UnityEngine;
using UnityEngine.EventSystems;

public class Podsvetka : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject holder;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        holder.gameObject.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        holder.gameObject.SetActive(false);
    }
}
