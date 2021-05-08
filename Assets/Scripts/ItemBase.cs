using System;

[Serializable]
public class ItemBase
{
    public string itemName;

    public ItemBase(string itemName)
    {
        this.itemName = itemName;
    }
}