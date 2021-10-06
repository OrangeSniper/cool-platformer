using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Currency Item", menuName = "Inventory System/Items/Currency")]
public class CurrencyItem : ItemObject
{
    public float worth;
    private void Awake()
    {
        type = ItemType.Currency;
    }
}
