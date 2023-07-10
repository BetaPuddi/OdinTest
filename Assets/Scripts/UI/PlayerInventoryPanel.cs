using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryPanel : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject itemPrefab;
    public Inventory inventory;
    public List<GameObject> itemPrefabs = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        UpdateInventory();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateInventory()
    {
        foreach (GameObject prefab in itemPrefabs)
        {
            Destroy(prefab);
        }
        itemPrefabs.Clear();
        foreach (InventoryItem inventoryItem in inventory.inventoryItems)
        {
            GameObject newInventoryItem = Instantiate(itemPrefab, inventoryPanel.transform) as GameObject;
            InventoryItemPrefab newItem = newInventoryItem.GetComponent<InventoryItemPrefab>();
            newItem.SetItem(inventoryItem);
            itemPrefabs.Add(newInventoryItem);
        }
    }
}
