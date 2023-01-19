using UnityEngine;
using UnityEngine.SceneManagement;

public class ProductionEntry : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private bool canEnterOnScene;
   
    private void OnTriggerEnter(Collider other)
    {
        canEnterOnScene = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canEnterOnScene = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canEnterOnScene)
            SceneManager.LoadScene(sceneName);
    }
}
