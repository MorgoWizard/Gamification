using System;
using UnityEngine;

public class Order : MonoBehaviour
{
    public string orderText;

    public Product product;

    private void Start()
    {
        product = GetComponentInChildren<Product>();

        orderText = "Здравствуйте! Я хочу у вас заказать " + product.name + ". Для этого нужно: ";
        for (int i = 0; i < product.technologicalProcessesNeed.Length; i++)
        {
            if (i == product.technologicalProcessesNeed.Length - 1)
            {
                orderText += product.technologicalProcessesNeed[i].name + ".";
            }
            else
            {
                orderText += product.technologicalProcessesNeed[i].name + ", ";
            }
        }
    }
}
