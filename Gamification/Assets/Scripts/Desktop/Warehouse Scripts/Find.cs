using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Find : MonoBehaviour
{
    public GameObject ContentHolder;
    public GameObject[] Element;
    public GameObject SearchBar;
    public int totalElements;

    void Start()
    {
        totalElements = ContentHolder.transform.childCount;
        Element = new GameObject[totalElements];
        for (int i = 0; i < totalElements; i++)
        {
            Element[i] = ContentHolder.transform.GetChild(i).gameObject;
        }
    }

    public void Search()
    {
        string SearchText = SearchBar.GetComponent<TMP_InputField>().text;
        int searchTxtlength = SearchText.Length;
        int searchedElements = 0;

        foreach(GameObject element in Element)
        {
            searchedElements += 1;

            if(element.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text.Length >= searchTxtlength)
            {
                if (SearchText.ToLower() == element.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Substring(0, searchTxtlength))
                    element.SetActive(true);
                else
                    element.SetActive(false);
            }
        }
    }

}
