using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Item", menuName = "Inventory System/Items/Weapon")]
public class WeaponItem : ItemObject
{
    private void Awake()
    {
        type = ItemType.Weapon;
    }
}
