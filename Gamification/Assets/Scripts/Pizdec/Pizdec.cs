using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pizdec : MonoBehaviour
{
    [SerializeField] private HelpApDis startingHelpPopUp;

    private void Start()
    {
        if(startingHelpPopUp != null)
            startingHelpPopUp.ChangeState();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PizdecNahuy()
    {
        Application.Quit();
    }
}
