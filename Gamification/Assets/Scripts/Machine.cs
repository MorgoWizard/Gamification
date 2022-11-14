using System;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public new string name;
    public string[] assortment;

    private void Start()
    {
        name = this.gameObject.name;
    }
}
