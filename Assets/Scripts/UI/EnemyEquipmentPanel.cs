using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEquipmentPanel : MonoBehaviour
{
    public EnemyInventory equipment;
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
        // Clears equippedItems and then sets each entry in equippedItems to an equipped item in the reference inventory
        equippedItems.Clear();
        if (equipment != null)
        {
            equippedItems.Insert(0, equipment.equippedWeaponRight);
            equippedItems.Insert(1, equipment.equippedWeaponLeft);
            equippedItems.Insert(2, equipment.equippedHeadArmour);
            equippedItems.Insert(3, equipment.equippedChestArmour);
            equippedItems.Insert(4, equipment.equippedHandArmour);
            equippedItems.Insert(5, equipment.equippedLegArmour);
            equippedItems.Insert(6, equipment.equippedFeetArmour);
        }

        // Destroys the existing prefabs
        foreach (GameObject equipmentItem in equipmentItemPrefabs)
        {
            Destroy(equipmentItem);
        }
        // Clears the prefab list
        equipmentItemPrefabs.Clear();

        /** Creates a new prefab for each equipped item
        *   Sets the item to the prefab
        *   Adds the prefab to the equipmentItemPrefabs list
        *   Set item index to the prefab
        */
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
