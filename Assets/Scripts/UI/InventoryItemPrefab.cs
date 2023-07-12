using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemPrefab : MonoBehaviour
{
    public delegate void ShowItemStats(InventoryItem item);
    public static event ShowItemStats OnShowItemStats;
    public InventoryItem inventoryItem = null;
    public TextMeshProUGUI itemInSlotText;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        itemInSlotText.text = inventoryItem.itemName.ToString();
    }

    public void SetItem(InventoryItem inventoryItem)
    {
        this.inventoryItem = inventoryItem;
        itemInSlotText.text = inventoryItem.itemName;
    }

    public void OnClick()
    {
        if (OnShowItemStats != null)
        {
            OnShowItemStats(inventoryItem);
        }
    }
}
