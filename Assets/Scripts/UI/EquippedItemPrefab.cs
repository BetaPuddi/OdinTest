using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EquippedItemPrefab : MonoBehaviour
{
    public delegate void ShowItemPanel();
    public static event ShowItemPanel OnShowItemPanel;
    public delegate void ShowItemStats(InventoryItem item);
    public static event ShowItemStats OnClickItem;
    public delegate void IsEquippedCheck(bool isEquipped);
    public static event IsEquippedCheck OnIsEquippedCheck;
    public delegate void SetItemIndex(int index);
    public static event SetItemIndex OnSetItemIndex;
    public delegate void SetEnemyItemStats(InventoryItem item);
    public static event SetEnemyItemStats OnClickEnemyItem;
    public delegate void ShowEnemyItemPanel();
    public static event ShowEnemyItemPanel OnShowEnemyItemPanel;
    public delegate void IsEnemyItemEquippedCheck(bool isEquipped);
    public static event IsEnemyItemEquippedCheck OnIsEnemyItemEquippedCheck;
    public delegate void SetEnemyItemIndex(int index);
    public static event SetItemIndex OnSetEnemyItemIndex;
    public InventoryItem inventoryItem = null;
    public TextMeshProUGUI itemInSlotText;
    public int itemIndex;
    public bool isEnemyItem;
    //public GameObject itemStatsPanel;
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
                OnIsEquippedCheck(true);
            }
            if (OnSetItemIndex != null)
            {
                OnSetItemIndex(itemIndex);
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
                OnIsEnemyItemEquippedCheck(true);
            }
            if (OnSetEnemyItemIndex != null)
            {
                OnSetEnemyItemIndex(itemIndex);
            }
        }
    }
}
