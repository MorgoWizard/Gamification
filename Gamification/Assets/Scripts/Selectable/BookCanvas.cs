using UnityEngine;

public class BookCanvas : MonoBehaviour
{
    public void OnDisable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Camera.main.GetComponent<Camera_WithSelectable>().enabled = true;
    }
}