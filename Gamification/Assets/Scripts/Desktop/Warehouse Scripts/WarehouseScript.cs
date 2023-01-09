using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class WarehouseScript : MonoBehaviour
{
	[SerializeField] private List<WareHouseData> warehouseData = new List<WareHouseData>();

    private void Awake()
    {
		//SortListByName();
	}

    void Start()
	{
		GameObject itemTemplate = transform.GetChild(0).gameObject;
		GameObject g;


		for (int i = 0; i < warehouseData.Count; i++)
		{
			g = Instantiate(itemTemplate, transform);
			g.transform.GetChild(0).GetComponent<Image>().sprite = warehouseData[i].icon;
			g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = warehouseData[i].productName.ToString();
			g.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = warehouseData[i].productAmount.ToString();
			g.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = warehouseData[i].productDescription.ToString();

		}

		Destroy(itemTemplate);
	}

	private void SortListByName()
	{
		warehouseData.Sort((N1, N2) => N1.productName.CompareTo(N2.productName));
	}

}