using System;
using UnityEngine;

/*
 * TODO:
 * 1) Повернулся в сторону - открыл экран
 * 2) 
*/

public class ActionOpener : MonoBehaviour
{
    [SerializeField] private Canvas computer, client;

    private CamControl _camControl;

    private void Start()
    {
        _camControl = gameObject.GetComponent<CamControl>();
    }

    void Update()
    {
        if(Input.GetKeyDown("e")) Iteract(transform.rotation);
    }

    private void Iteract(Quaternion quaternion)
    {
        if (quaternion.eulerAngles.y < 270)
        {
            ChangeActivity(computer.gameObject);
        }
        else
        {
            ChangeActivity(client.gameObject);
        }
    }
    
    private void ChangeActivity(GameObject obj)
    {
        obj.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        _camControl.enabled = false;
    }

    public void ChangeBack()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _camControl.enabled = true;
    }
}