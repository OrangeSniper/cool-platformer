using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Database", menuName = "Inventory System/Items/Database")]
public class ItemDatabase : ScriptableObject, ISerializationCallbackReceiver
{
    public ItemObject[] items;
    public Dictionary<ItemObject, int> GetId = new Dictionary<ItemObject, int>();

    public void OnAfterDeserialize()
    {
        GetId = new Dictionary<ItemObject, int>();
        for (int i = 0; i < items.Length; i++)
        {
            GetId.Add(items[i], i);
        }
    }

    public void OnBeforeSerialize()
    {

    }
}
