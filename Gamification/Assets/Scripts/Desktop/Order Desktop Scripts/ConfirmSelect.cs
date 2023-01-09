using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmSelect : MonoBehaviour
{
    [SerializeField] GameObject selectTemplateWindow;
    [SerializeField] GameObject technicalCardWindow;
    [SerializeField] GameObject lastStageWindow;
    [SerializeField] GameObject confirmCardWindow;
    [SerializeField] GameObject bottomButtons;
    [SerializeField] GameObject CloseButton;
    [SerializeField] GameObject OrderText;

    public void ConfirmSelectButton()
    {
        selectTemplateWindow.SetActive(false);
        technicalCardWindow.SetActive(true);
        lastStageWindow.SetActive(false);
    }
    public void ConfirmTechnicanCard()
    {
        selectTemplateWindow.SetActive(false);
        technicalCardWindow.SetActive(true);
        lastStageWindow.SetActive(false);
        confirmCardWindow.SetActive(true);
    }
    public void ConfirmPopUp()
    {
        selectTemplateWindow.SetActive(false);
        technicalCardWindow.SetActive(false);
        lastStageWindow.SetActive(true);
        confirmCardWindow.SetActive(false);
        bottomButtons.SetActive(false);
        CloseButton.SetActive(false);
        OrderText.SetActive(false);
    }
    public void ClosePopUp()
    {
        selectTemplateWindow.SetActive(false);
        technicalCardWindow.SetActive(true);
        lastStageWindow.SetActive(false);
        confirmCardWindow.SetActive(false);
    }

}
