using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInventoryPanel : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject itemPrefab;
    public Inventory inventory;
    public List<GameObject> inventoryItemPrefabs = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        UpdateInventory();
        Inventory.OnUpdateUI += UpdateInventory;
    }

    // Update is called once per frame
    void Update() { }

    public void UpdateInventory()
    {
        // Destroys prefabs
        foreach (GameObject prefab in inventoryItemPrefabs)
        {
            Destroy(prefab);
        }
        // Clears prefab list
        inventoryItemPrefabs.Clear();
        /** Creates prefabs and adds them to the list
        *   Sets the inventory items to the prefabs
        *
        */
        foreach (InventoryItem inventoryItem in inventory.inventoryItems)
        {
            GameObject newInventoryItem = Instantiate(itemPrefab, inventoryPanel.transform) as GameObject;
            InventoryItemPrefab newItem = newInventoryItem.GetComponent<InventoryItemPrefab>();
            newItem.SetItem(inventoryItem);
            inventoryItemPrefabs.Add(newInventoryItem);
        }
    }
}
