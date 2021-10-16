using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Currency,
    Default
}
public enum Attributes
{
    damage,
    speed,
    defense,
}
public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public Sprite uiDisplay;
    public ItemType type;
    [TextArea(15,20)]
    public string Description;

    public ItemBuff[] itemBuff;
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

public class ItemBuff
{
    public Attributes attribute;
    public int value;

    public int min;
    public int max;
    public ItemBuff(int _min, int _max)
    {
        min = _min;
        max = _max;
    }

    public void GenerateField()
    {
        value = Random.Range(min, max);
    }
}