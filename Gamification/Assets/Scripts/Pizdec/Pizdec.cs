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

    public void Change()
    {
        GameObject.FindWithTag("Player").GetComponent<Player>().Pokazh = true;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PizdecTiemru()
    {
        Destroy(GameObject.FindWithTag("Timer"));
    }

    public void PizdecNahuy()
    {
        Application.Quit();
    }
}
