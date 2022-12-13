using System;
using System.Collections.Generic;
using UnityEngine;

public class HelpDescrioptions : MonoBehaviour
{
    private Dictionary<string, string> _helpDescriptions;

    private void OnEnable() => Help.OnSwitchHelp += ChangeDescription;
    private void OnDisable() => Help.OnSwitchHelp -= ChangeDescription;

    private void ChangeDescription(string key)
    {
        if (_helpDescriptions.ContainsKey(key))
            Help.Description.text = _helpDescriptions[key];
        else
            Help.Description.text = string.Empty;
    }
}
