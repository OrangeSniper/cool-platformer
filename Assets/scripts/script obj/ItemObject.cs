using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Currency,
    Default
}
public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public Sprite uiDisplay;
    public ItemType type;
    [TextArea(15,20)]
    public string Description;
}

[System.Serializable]
public class Item
{
    public string name;
    public int ID;
    public Item(ItemObject item)
    {
        name = item.name;
        ID = item.Id;
    }
}