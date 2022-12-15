using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Animator transition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            LoadLevel();
        }
    }

    private void LoadLevel()
    {
        StartCoroutine(LoadLevelI());
    }

    IEnumerator LoadLevelI()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);;
    }
}
