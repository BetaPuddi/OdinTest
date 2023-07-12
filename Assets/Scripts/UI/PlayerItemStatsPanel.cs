using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerItemStatsPanel : MonoBehaviour
{
    public InventoryItem itemToShow;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    private void Start()
    {
        InventoryItemPrefab.OnShowItemStats += SetItem;
        EquippedItemPrefab.OnShowItemStats += SetItem;
    }
    public void SetItem(InventoryItem item)
    {
        itemToShow = item;
        nameText.text = itemToShow.itemName;
        descriptionText.text = itemToShow.itemDescription;
    }
}
