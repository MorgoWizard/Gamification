using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class PointCollectorSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI summaryPointAmount;

    [SerializeField] private TextMeshProUGUI pointText1;
    [SerializeField] private TextMeshProUGUI pointText2;
    [SerializeField] private TextMeshProUGUI pointText3;
    [SerializeField] private TextMeshProUGUI pointText4;
    [SerializeField] private TextMeshProUGUI pointText5;
    [SerializeField] private TextMeshProUGUI pointText6;
    [SerializeField] private TextMeshProUGUI pointText7;

    private int pointSum, point1, point2, point3, point4, point5, point6, point7;

    private void OnEnable()
    {
        GetSomePoints();
    }

    private void GetSomePoints()
    {
        point1 = Random.Range(6, 8);
        point2 = Random.Range(4, 5);
        point3 = Random.Range(5, 9);
        point4 = Random.Range(9, 12);
        point5 = Random.Range(5, 7);
        point6 = Random.Range(5, 6);
        point7 = Random.Range(6, 8);
        pointSum = point1 + point2 + point3 + point4 + point5 + point6 + point7;

        summaryPointAmount.text = pointSum.ToString();
        pointText1.text = point1.ToString();
        pointText2.text = point2.ToString();
        pointText3.text = point3.ToString();
        pointText4.text = point4.ToString();
        pointText5.text = point5.ToString();
        pointText6.text = point6.ToString();
        pointText7.text = point7.ToString();
    }
}
