using UnityEngine;
using UnityEngine.SceneManagement;

public class Pizdec : MonoBehaviour
{
    public void StartOffice()
    {
        SceneManager.LoadScene("Office");
    }

    public void PizdecNahuy()
    {
        Application.Quit();
    }
}
