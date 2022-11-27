using UnityEngine;

[System.Serializable]
public struct Material
{
    public string type;
    public int density;
    public int whiteness;

    public Material(string type, int density, int whiteness)
    {
        this.type = type;
        this.density = density;
        this.whiteness = whiteness;
    }
}

public class Product : MonoBehaviour
{
    public new string name;

    public string size = "15x15 см";
    public int count = 5000;
    public technologicalProcess[] technologicalProcessesNeed;
    public Material material;

    private void Start()
    {
        material = new Material("целлюлозном картоне", 300, 110);
        technologicalProcessesNeed = GetComponentsInChildren<technologicalProcess>();
    }
}
