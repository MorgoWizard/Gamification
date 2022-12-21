using UnityEngine;

public class ActionOpener : MonoBehaviour
{
    [SerializeField] private GameObject computer, dialogue, box;

    private CamControl _camControl;
    private bool activateBox = true;

    private void Start()
    {
        _camControl = gameObject.GetComponent<CamControl>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) Interact(transform.rotation);

        if (Input.GetKeyDown(KeyCode.Y))
        {
            box.SetActive(activateBox);
            activateBox = !activateBox;
        }
    }

    private void Interact(Quaternion quaternion)
    {
        ChangeActivity(quaternion.eulerAngles.y < 270 ? computer : dialogue);
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