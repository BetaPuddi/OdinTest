using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryPanel : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject itemPrefab;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        foreach (InventoryItem inventoryItem in inventory.inventoryItems)
        {
            GameObject newInventoryItem = Instantiate(itemPrefab, inventoryPanel.transform) as GameObject;
            InventoryItemPrefab newItem = newInventoryItem.GetComponent<InventoryItemPrefab>();
            newItem.SetItem(inventoryItem);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*foreach (InventoryItem inventoryItem in inventory.inventoryItems)
        {
            Instantiate(itemPrefab, inventoryPanel.transform);
        }*/
    }
}
