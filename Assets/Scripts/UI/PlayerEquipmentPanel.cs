using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipmentPanel : MonoBehaviour
{
    public Inventory equipment;
    public GameObject equipmentPanel;
    public GameObject equipmentItemPrefab;
    public List<GameObject> equipmentItemPrefabs = new List<GameObject>();
    public List<InventoryItem> equippedItems = new List<InventoryItem>();

    // Start is called before the first frame update
    void Start()
    {
        UpdateEquipment();
        Inventory.OnUpdateUI += UpdateEquipment;
    }

    // Update is called once per frame
    void Update() { }

    public void UpdateEquipment()
    {
        equippedItems.Clear();
        equippedItems.Insert(0, equipment.equippedWeaponRight);
        equippedItems.Insert(1, equipment.equippedWeaponLeft);
        equippedItems.Insert(2, equipment.equippedHeadArmour);
        equippedItems.Insert(3, equipment.equippedChestArmour);
        equippedItems.Insert(4, equipment.equippedHandArmour);
        equippedItems.Insert(5, equipment.equippedLegArmour);
        equippedItems.Insert(6, equipment.equippedFeetArmour);

        foreach (GameObject equipmentItem in equipmentItemPrefabs)
        {
            Destroy(equipmentItem);
        }
        equipmentItemPrefabs.Clear();
        /*foreach (InventoryItem item in equipment.equippedItems)
        {
            GameObject equipmentItem = Instantiate(equipmentItemPrefab, equipmentPanel.transform) as GameObject;
            EquippedItemPrefab newItem = equipmentItem.GetComponent<EquippedItemPrefab>();
            newItem.SetItem(item);
            newItem.itemIndex = equipmentItemPrefabs.;
            equipmentItemPrefabs.Add(equipmentItem);
        }*/
        for (int i = 0; i < equippedItems.Count; i++)
        {
            GameObject equipmentItem = Instantiate(equipmentItemPrefab, equipmentPanel.transform) as GameObject;
            EquippedItemPrefab newItem = equipmentItem.GetComponent<EquippedItemPrefab>();
            newItem.SetItem(equippedItems[i]);
            equipmentItemPrefabs.Add(equipmentItem);
            equipmentItemPrefabs[i].GetComponent<EquippedItemPrefab>().itemIndex = i;
        }
    }
}
