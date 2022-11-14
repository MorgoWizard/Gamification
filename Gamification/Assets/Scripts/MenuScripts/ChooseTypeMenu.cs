using UnityEngine;

namespace MenuScripts
{
    public class ChooseTypeMenu : MonoBehaviour
    {
        [SerializeField] private GameObject typeManager;

        private void Start()
        {
            typeManager = GameObject.Find("TypeManager");
        }
    }
}
