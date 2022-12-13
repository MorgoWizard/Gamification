using System;
using TMPro;
using UnityEngine;

public class Help : MonoBehaviour
{
    public static event Action<string> OnSwitchHelp;
    public static TextMeshProUGUI Description;

    private string _locationName;

    private void Start()
    {
        Description = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void OpenPopUp()
    {
        OnSwitchHelp?.Invoke(_locationName);
        
        // появление поп апа
    }

    public void ClosePopUp()
    {

    }

    public void SwitchLocation(string name)
    {
        _locationName = name;
    }
}
