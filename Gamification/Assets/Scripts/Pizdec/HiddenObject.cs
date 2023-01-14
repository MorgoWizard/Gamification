using UnityEngine;

public class HiddenObject : MonoBehaviour
{
    public GameObject[] hiddenObjects;
    public Transform dialoguePosition;
    void Start()
    {
        if (GameObject.FindWithTag("Player").GetComponent<Player>().Pokazh)
        {
            foreach (var hiddenObject in hiddenObjects)
            {
                hiddenObject.SetActive(true);
            }
            var playerTransform = transform;
            playerTransform.position = dialoguePosition.position;
            playerTransform.rotation = dialoguePosition.rotation;
            GetComponent<FirstPersonMovement>().enabled = false;
            GetComponent<Jump>().enabled = false;
            GetComponent<Crouch>().enabled = false;
            GetComponentInChildren<FirstPersonLook>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
