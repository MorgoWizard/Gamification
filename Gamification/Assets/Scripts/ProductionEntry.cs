using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProductionEntry : MonoBehaviour
{
    [SerializeField] private string sceneName;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene(sceneName);
    }
    
}
