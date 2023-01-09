[System.Serializable]
public struct WareHouseData
{
    public string productName;
    public string productDescription;
    public string productAmount;
    public UnityEngine.Sprite icon;

    public WareHouseData(string productName, string productDescription, string productAmount, UnityEngine.Sprite icon)
    {
        this.productName = productName;
        this.productDescription = productDescription;
        this.productAmount = productAmount;
        this.icon = icon;
    }

}
