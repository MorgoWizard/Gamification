using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MultiManager : MonoBehaviour
{
    [SerializeField] private HelpApDis startingHelpPopUp;

    private void Start()
    {
        if(startingHelpPopUp != null)
            startingHelpPopUp.ChangeState();
    }

    public void Change()
    {
        GameObject.FindWithTag("Player").GetComponent<Player>().showing = true;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void DestroyTimer()
    {
        Destroy(GameObject.FindWithTag("Timer"));
    }

    public void ApplicationQuit()
    {
        Application.Quit();
    }
}
