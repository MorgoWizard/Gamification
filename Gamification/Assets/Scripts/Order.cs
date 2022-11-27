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

        orderText = "Здравствуйте! Хочу заказать у Вас " + product.name + ", формата " + product.size + ", тиражом " + product.count +
                     " экземпляров. Она должна быть изготовлена на " + product.material.type + " " + product.material.density + " г/м2, белизной " + product.material.whiteness +
                     "%. Конструкция упаковки — ласточкин хвост. Печать 4+0, ламинация, выборочный УФ-лак. У меня есть готовый дизайн-макет. Заказ должен" +
                     " быть изготовлен за " + time + ". Скажите, пожалуйста, Вы сможете это сделать в указанный срок?";
    }
}

// тест
