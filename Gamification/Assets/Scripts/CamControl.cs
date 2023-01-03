using UnityEngine;

public class CamControl : MonoBehaviour
{
    [SerializeField] private float minClamp, maxClamp;
    
    public float mouseSensitivity = 100f;

    private float _yRotation;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        
        _yRotation += mouseX;
        _yRotation = Mathf.Clamp(_yRotation, minClamp, maxClamp);

        transform.localRotation = Quaternion.Euler(0f, _yRotation, 0f);
    }
}