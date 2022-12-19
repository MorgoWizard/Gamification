using UnityEngine;

public class CamControl : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    private Transform _cam;

    private float _xRotation;

    private void OnEnable()
    {
        _cam = this.gameObject.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        
        _cam.Rotate(Vector3.up * mouseX);
    }
}