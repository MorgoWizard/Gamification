using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmSelect : MonoBehaviour
{
    [SerializeField] GameObject selectTemplateWindow;
    [SerializeField] GameObject technicalCardWindow;
    [SerializeField] GameObject lastStageWindow;

    public void ConfirmSelectButton()
    {
        selectTemplateWindow.SetActive(false);
        technicalCardWindow.SetActive(true);
        lastStageWindow.SetActive(false);
    }

}
