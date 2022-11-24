using System;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public string currentText;
    private GameObject _buttonsHolder;
    [SerializeField] private GameObject[] buttons;

    [SerializeField] private TextMeshProUGUI manTalking;
    private void Start()
    {
        _buttonsHolder = GameObject.FindWithTag("Buttons");
        GameObject order = GameObject.FindWithTag("Order");
        currentText = order.GetComponent<Order>().orderText;
        manTalking.text = currentText;
    }

    public void YesItsReal()
    {
        manTalking.text = "Хорошо. Сколько это будет стоить?";
        FindNeed("TakeOrder");
    }

    public void TakeOrder()
    {
        manTalking.text = "Отлично, если я Вам понадоблюсь, вот мой мессенджер!";
        FindNeed("ThankU");
    }

    public void ThankU()
    {
        gameObject.SetActive(false);
    }

    public void NeedMoreTime()
    {
        manTalking.text = "С чем это связано?";
        string[] newButtons = {"Timeout", "ProductionLoaded", "ImDumb","OutOfStock"};
        FindNeed(newButtons);
    }

    public void ProductionLoaded()
    {
        manTalking.text = "Хорошо, давайте поставим мой заказ в приоритет. Увеличиваю стоимость на 10%";
        string[] newButtons = {"TakeOrder+", "WeCant"};
        FindNeed(newButtons);
    }

    private void FindNeed(string need)
    {
        foreach (var button in buttons)
        {
            button.SetActive(button.name == need);
        }
    }
    
    private void FindNeed(string[] need)
    {
        bool setActive;
        foreach (var button in buttons)
        {
            setActive = false;
            foreach (var needName in need)
            {
                setActive = button.name==needName;
                if (setActive == true) break;
            }
            button.SetActive(setActive);
        }
    }
}