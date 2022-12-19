using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private Menu[] menus;

        public void OpenMenu(string menuName)
        {
            foreach (var menu in menus)
            {
                if (menu.menuName == menuName)
                {
                    OpenMenu(menu);
                }
                else if (menu.isOpen)
                {
                    CloseMenu(menu);
                }
            }
        }

        private void OpenMenu(Menu menu)
        {
            foreach (var currentMenu in menus)
            {
                if(currentMenu.isOpen) CloseMenu(currentMenu);
            }
            menu.Open();
        }

        private void CloseMenu(Menu menu)
        {
            menu.Close();
        }
    }
}
