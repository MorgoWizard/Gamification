using UnityEngine;

public class Computer_Selectable : Selectable
{
    [SerializeField] private Canvas _computerCanvas;

    private void Start()
    {
        if (_computerCanvas == null)
            this.enabled = false;
    }

    public override void OnClick()
    {
        _computerCanvas.gameObject.SetActive(true);
        Camera.main.GetComponent<Camera_WithSelectable>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnClose()
    {
        _computerCanvas.gameObject.SetActive(false);
        Camera.main.GetComponent<Camera_WithSelectable>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
