using UnityEngine;
using UnityEngine.SceneManagement;

public class Pizdec : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PizdecNahuy()
    {
        Application.Quit();
    }
}
