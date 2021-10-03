using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey.Utils;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;

    public Transform itemSlotContainer;
    public Transform itemSlotTemplate;

    private PlayerMov player;

    public void SetPlayer(PlayerMov player)
    {
        this.player = player;
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;

        inventory.OnItemListChanged += Inventory_OnItemListChanged;
        RefreshInventoryItems();
    }

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e)
    {
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach (Transform child in itemSlotContainer)
        {
            if (child == itemSlotTemplate) continue;
            Destroy(child.gameObject);
        }
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 100f;
        foreach(Item item in inventory.GetItemList())
        {
            RectTransform itemslotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemslotRectTransform.gameObject.SetActive(true);

            itemslotRectTransform.GetComponent<Button_UI>().ClickFunc = () =>
            {
                //use item
            };

            itemslotRectTransform.GetComponent<Button_UI>().MouseRightClickFunc = () =>
            {
                //drop item
                Item duplicateItem = new Item { amount = item.amount, itemType = item.itemType };
                inventory.RemoveItem(item);
                ItemWorld.DropItem(player.transform.position, duplicateItem);
            };
            itemslotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            Image image = itemslotRectTransform.Find("item image").GetComponent<Image>();
            image.sprite = item.GetSprite();
            TextMeshProUGUI uiText = itemslotRectTransform.Find("text").GetComponent<TextMeshProUGUI>();
            if(item.amount > 1)
            {
                uiText.SetText(item.amount.ToString());
            }else
            {
                uiText.SetText("");
            }
            
            x++;
            if(x > 11)
            {
                x = 0;
                y++;
            }
        }
    }
}
