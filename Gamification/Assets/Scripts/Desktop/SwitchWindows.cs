using UnityEngine;

public class SwitchWindows : MonoBehaviour
{
    [SerializeField] GameObject orderWindow;
    [SerializeField] GameObject maketWindow;
    [SerializeField] GameObject fabricationWindow;
    [SerializeField] GameObject warehousWindow;
    [SerializeField] GameObject baseWindow;

    public void OrderButton()
    {
        orderWindow.SetActive(true);
        maketWindow.SetActive(false);
        fabricationWindow.SetActive(false);
        warehousWindow.SetActive(false);
        baseWindow.SetActive(false);
    }
    public void MaketButton()
    {
        orderWindow.SetActive(false);
        maketWindow.SetActive(true);
        fabricationWindow.SetActive(false);
        warehousWindow.SetActive(false);
        baseWindow.SetActive(false);
    }
    public void FabricationButton()
    {
        orderWindow.SetActive(false);
        maketWindow.SetActive(false);
        fabricationWindow.SetActive(true);
        warehousWindow.SetActive(false);
        baseWindow.SetActive(false);
    }
    public void WarehouseButton()
    {
        orderWindow.SetActive(false);
        maketWindow.SetActive(false);
        fabricationWindow.SetActive(false);
        warehousWindow.SetActive(true);
        baseWindow.SetActive(false);
    }
    public void BaseButton()
    {
        orderWindow.SetActive(false);
        maketWindow.SetActive(false);
        fabricationWindow.SetActive(false);
        warehousWindow.SetActive(false);
        baseWindow.SetActive(true);
    }

}
