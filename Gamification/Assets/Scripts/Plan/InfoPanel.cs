using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    public void ChangeActive()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
