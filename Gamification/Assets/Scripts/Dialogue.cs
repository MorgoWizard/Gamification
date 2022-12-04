using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private Player player; 
    
    public string currentText;
    private GameObject _buttonsHolder;
    [SerializeField] private GameObject[] buttons;

    [SerializeField] private GameObject resultScreen;
    [SerializeField] private TextMeshProUGUI resultText;

    [SerializeField] private TextMeshProUGUI manTalking;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        _buttonsHolder = GameObject.FindWithTag("Buttons");
        GameObject order = GameObject.FindWithTag("Order");
        currentText = order.GetComponent<Order>().orderText;
        manTalking.text = currentText;
    }

    /*public void YesItsReal()
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
    }*/

    /*private void FindNeed(string need)
    {
        foreach (var button in buttons)
        {
            button.SetActive(button.name == need);
        }
    }*/

    public void OnOffDialogue()
    {
        this.gameObject.SetActive(this.gameObject.activeInHierarchy != true);
    }

    public void Yes()
    {
        string[] temp = { "VariantTrue", "VariantFalse" };
        FindNeed(temp);
    }

    public void VariantTrue()
    {
        string[] temp = {"Result"};
        FindNeed(temp);
        manTalking.text = "Да, устроит. Спасибо! Макет сбросил";
    }
    
    public void VariantFalse()
    {
        player.WrongAnswer();
        string[] temp = {"Result"};
        FindNeed(temp);
        manTalking.text = "Да, устроит. Спасибо! Макет сбросил";
    }

    public void Result()
    {
        GameObject[] toOff = GameObject.FindGameObjectsWithTag("ToOff");
        foreach (var obj in toOff)
        {
            obj.SetActive(false);
        }
        resultScreen.SetActive(true);
        resultText.text = player.ReturnScore().ToString();
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
