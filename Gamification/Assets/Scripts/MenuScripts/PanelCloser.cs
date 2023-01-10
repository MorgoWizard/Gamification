using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCloser : MonoBehaviour
{
    public void CloseAllPanels()
    {
        GameObject[] panels;
        panels = GameObject.FindGameObjectsWithTag("Panel");

        foreach (var panel in panels)
        {
            panel.gameObject.SetActive(false);
        }
    }
}
