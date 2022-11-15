using UnityEngine;

public class Book_Selectable : Selectable
{
    [SerializeField] private float _scaleMultiplier = 1.2f;
    [SerializeField] private GameObject _bookCanvas;

    public override void Select()
    {
        transform.localScale *= _scaleMultiplier;
    }

    public override void Deselect()
    {
        transform.localScale /= _scaleMultiplier;
    }

    public override void OnClick()
    {
        Cursor.lockState = CursorLockMode.None;
        Camera.main.GetComponent<Camera_WithSelectable>().enabled = false;
        _bookCanvas.SetActive(true);
    }
}
