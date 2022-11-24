using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class technologicalProcess : MonoBehaviour
{
    public new string name;
    
    private void Start()
    {
        name = this.gameObject.name;
    }
}
