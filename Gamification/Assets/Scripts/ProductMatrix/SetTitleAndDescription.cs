using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class SetTitleAndDescription : MonoBehaviour
{
    [CanBeNull][SerializeField] private TextMeshProUGUI titleText;
    [CanBeNull][SerializeField] private TextMeshProUGUI descText;

    private void OnEnable() => OnMouseOverInfo.SetTexts += UpdateTexts;
    private void OnDisable() => OnMouseOverInfo.SetTexts -= UpdateTexts;

    private void UpdateTexts(string Title, string Description)
    {
        if(titleText != null)
            titleText.text = Title;
        if (descText != null)
            descText.text = Description;
    }
}
