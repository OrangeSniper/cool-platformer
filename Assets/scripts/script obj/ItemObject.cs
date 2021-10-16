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
    defense
}
public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public Sprite uiDisplay;
    public ItemType type;
    [TextArea(15,20)]
    public string Description;

    public ItemBuff[] Buffs;

    public Item CreateItem()
    {
        Item newItem = new Item(this);
        return newItem;
    }
}

[System.Serializable]
public class Item
{
    public string name;
    public int ID;
    public ItemBuff[] Buffs;
    public Item(ItemObject item)
    {
        name = item.name;
        ID = item.Id;
        Buffs = new ItemBuff[item.Buffs.Length];
        for (int i = 0; i < Buffs.Length; i++)
        {
            Buffs[i] = new ItemBuff(item.Buffs[i].min, item.Buffs[i].max);
            Buffs[i].attribute = item.Buffs[i].attribute;
        }
    }
}

[System.Serializable]
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
        GenerateField();
    }

    public void GenerateField()
    {
        value = Random.Range(min, max);
    }
}