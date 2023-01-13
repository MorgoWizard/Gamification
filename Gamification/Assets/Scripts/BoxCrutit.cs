using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class BoxCrutit : MonoBehaviour
{
    [SerializeField] private Scrollbar scrollbar;
    [SerializeField] private Transform objectTransform;

    private void Update()
    {
        objectTransform.rotation = Quaternion.Euler(0f, scrollbar.value * 360f, 0f);
    }
}
