using System;
using UnityEngine;

public class Order : MonoBehaviour
{
    public string orderText;

    public Product product;

    public string time = "1-2 недели";

    private void Start()
    {
        product = GetComponentInChildren<Product>();

        orderText = "Здравствуйте! Хочу заказать у Вас подарочную коробку, формата 820x560 мм, тиражом в 5000 экземпляров. Она должна быть изготовлена на гофрокартоне Т14, буром. Конструкция упаковки — оригинальная. Печать CMYK. У меня есть готовый дизайн-макет. Заказ должен быть изготовлен за 1-2 недели. Скажите, пожалуйста, Вы сможете это сделать в указанный срок?";
    }
}

// тест
