using UnityEngine;

public class Type : MonoBehaviour
{
    public new string name, address;
    public Machine[] machines;

    private void Start()
    {
        name = this.gameObject.name;
        machines = GetComponentsInChildren<Machine>();
    }
}
