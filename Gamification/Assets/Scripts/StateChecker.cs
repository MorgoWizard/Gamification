using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChecker : MonoBehaviour
{
    [SerializeField] private GameObject dialogueObject;
    [SerializeField] private CamControl camControl;

    public void CameraSwitch()
    {
        camControl.enabled = !dialogueObject.activeInHierarchy;
    }
}
