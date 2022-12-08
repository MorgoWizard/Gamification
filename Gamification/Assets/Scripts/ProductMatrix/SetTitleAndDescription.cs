using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetTitleAndDescription : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI descText;

    private void OnEnable() => OnMouseOverInfo.SetTexts += UpdateTexts;
    private void OnDisable() => OnMouseOverInfo.SetTexts -= UpdateTexts;

    private void UpdateTexts(string Title, string Description)
    {
        titleText.text = Title;
        descText.text = Description;
    }

}
