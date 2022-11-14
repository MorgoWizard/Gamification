using UnityEngine;


public class TypeManager : MonoBehaviour
{
    public Type[] types;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        types = GetComponentsInChildren<Type>();
    }
}
