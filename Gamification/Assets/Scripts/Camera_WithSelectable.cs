using System;
using UnityEngine;

public class Camera_WithSelectable : MonoBehaviour
{
    [SerializeField, Tooltip("Mouse sensetivity")] private float _sensetivity = 100f;
    [SerializeField, Range(0f, 90f), Tooltip("Maximun angle of camera rotation along the local 'x' axis")] private float _clampAngle = 90f;

    private float _xRotation, _yRotation;

    private Selectable _currentSelectable;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        _xRotation = transform.rotation.eulerAngles.x;
        _yRotation = transform.rotation.eulerAngles.y;
    }

    private void Update()
    {
        Rotate();
        Select();

        if (Input.GetMouseButtonDown(0) && _currentSelectable)
            _currentSelectable.OnClick();
    }

    private void Rotate()
    {
        _xRotation -= Input.GetAxis("Mouse Y") * _sensetivity * Time.deltaTime;
        _yRotation += Input.GetAxis("Mouse X") * _sensetivity * Time.deltaTime;

        _xRotation = Mathf.Clamp(_xRotation, -_clampAngle, _clampAngle);

        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0f);
    }

    private void Select()
    {
        // луч в позиции мышки (при 'CursorLockMode.Locked' будет в центре экрана)
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // луч в центре экрана
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Selectable selectable = hit.transform.GetComponent<Selectable>();
            if (selectable)
            {
                if (_currentSelectable)
                {
                    if (_currentSelectable != selectable)
                    {
                        _currentSelectable.Deselect();
                        selectable.Select();
                        _currentSelectable = selectable;
                    }
                }
                else
                {
                    selectable.Select();
                    _currentSelectable = selectable;
                }
            }
            else if (_currentSelectable)
            {
                _currentSelectable.Deselect();
                _currentSelectable = null;
            }
        }
        else if (_currentSelectable)
        {
            _currentSelectable.Deselect();
            _currentSelectable = null;
        }
    }
}