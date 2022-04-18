public class Product
{
    public Product(string name, int newID)
    {
        ItemName = name;
        ItemID = newID;
    }

    public string ItemName = string.Empty;
    public int ItemID { get; set; }

    public ref string GetItemName()
    {
        return ref ItemName;
    }
}
