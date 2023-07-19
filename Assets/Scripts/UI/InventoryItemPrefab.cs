using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemPrefab : MonoBehaviour
{
    public delegate void SetItemStats(InventoryItem item);
    public static event SetItemStats OnClickItem;
    public delegate void ShowItemPanel();
    public static event ShowItemPanel OnShowItemPanel;
    public delegate void IsEquippedCheck(bool isEquipped);
    public static event IsEquippedCheck OnIsEquippedCheck;
    public delegate void SetEnemyItemStats(InventoryItem item);
    public static event SetEnemyItemStats OnClickEnemyItem;
    public delegate void ShowEnemyItemPanel();
    public static event ShowEnemyItemPanel OnShowEnemyItemPanel;
    public delegate void IsEnemyItemEquippedCheck(bool isEquipped);
    public static event IsEnemyItemEquippedCheck OnIsEnemyItemEquippedCheck;
    public InventoryItem inventoryItem = null;
    public TextMeshProUGUI itemInSlotText;
    public int sortingNumber;
    public bool isEnemyItem;
    // Start is called before the first frame update
    void Start()
    { }

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
        if (isEnemyItem == false)
        {
            if (OnShowItemPanel != null)
            {
                OnShowItemPanel();
            }
            if (OnClickItem != null)
            {
                OnClickItem(inventoryItem);
            }
            if (OnIsEquippedCheck != null)
            {
                OnIsEquippedCheck(false);
            }
        }
        else if (isEnemyItem == true)
        {
            if (OnShowEnemyItemPanel != null)
            {
                OnShowEnemyItemPanel();
            }
            if (OnClickEnemyItem != null)
            {
                OnClickEnemyItem(inventoryItem);
            }
            if (OnIsEnemyItemEquippedCheck != null)
            {
                OnIsEnemyItemEquippedCheck(false);
            }
        }
    }
}
