using TMPro;
using UnityEngine;

namespace MenuScripts
{
    public class DescriptionController : MonoBehaviour
    {
        [SerializeField] private TypeManager typeManager;
        
        [SerializeField] private TMP_Text descriptionText;
        [SerializeField] private TMP_Text addressText;
        [SerializeField] private TMP_Dropdown dropdownType;

        private void Start()
        {
            ChangeDescription();
        }

        public void ChangeDescription()
        {
            string chosenType = dropdownType.captionText.text;
            string description = "";
            for (int i = 0; i < typeManager.types.Length; i++)
            {
                if (typeManager.types[i].name == chosenType)
                {
                    addressText.text = typeManager.types[i].address;
                    for (int j = 0; j < typeManager.types[i].machines.Length; j++)
                    {
                        description += typeManager.types[i].machines[j].name + "\n";
                    }
                    descriptionText.text = description;
                    return;
                }
            }
        }
    }
}
