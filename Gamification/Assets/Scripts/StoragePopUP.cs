using UnityEngine;
using UnityEngine.SceneManagement;

public class StoragePopUP : MonoBehaviour
{
    [SerializeField] private HelpApDis popUpButton;
    [SerializeField] private string sceneName;
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
            SceneManager.LoadScene(sceneName);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
