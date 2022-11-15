using UnityEngine;

public class Selectable : MonoBehaviour
{
    public virtual void Select()
    { }

    public virtual void Deselect()
    { }

    public virtual void OnClick()
    { }
}