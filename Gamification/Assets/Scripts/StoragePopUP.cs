using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoragePopUP : MonoBehaviour
{
    [SerializeField] private HelpApDis popUpButton;
    private void Start()
    {
        popUpButton.ChangeState();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            popUpButton.ChangeState();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Office");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
