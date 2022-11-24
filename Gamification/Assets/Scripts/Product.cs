using UnityEngine;

public class Product : MonoBehaviour
{
    public new string name;
    public technologicalProcess[] technologicalProcessesNeed;

    private void Start()
    {
        name = this.gameObject.name;
        technologicalProcessesNeed = GetComponentsInChildren<technologicalProcess>();
    }
}
