using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public WeaponBase equippedWeaponRight = null;
    public WeaponBase equippedWeaponLeft = null;
    public ArmourBase equippedHeadArmour = null;
    public ArmourBase equippedChestArmour = null;
    public ArmourBase equippedHandArmour = null;
    public ArmourBase equippedLegArmour = null;
    public ArmourBase equippedFeetArmour = null;

    public List<InventoryItem> inventoryItems = new List<InventoryItem>();

    public void AddItem(InventoryItem item)
    {
        inventoryItems.Add(item);
    }
    public void RemoveItem(InventoryItem item)
    {
        inventoryItems.Remove(item);
    }
    public void RemoveAllItems()
    {
        inventoryItems.Clear();
    }
    public bool HasItem(InventoryItem item)
    {
        return inventoryItems.Contains(item);
    }
    public bool IsEmpty()
    {
        return inventoryItems.Count == 0;
    }
    public int Count()
    {
        return inventoryItems.Count;
    }
    public InventoryItem GetItem(int index)
    {
        return inventoryItems[index];
    }
    public void SetItem(int index, InventoryItem item)
    {
        inventoryItems[index] = item;
    }
    public InventoryItem[] GetItems()
    {
        return inventoryItems.ToArray();
    }
    public void SetItems(InventoryItem[] items)
    {
        inventoryItems = new List<InventoryItem>(items);
    }
    public void SetRightWeapon(WeaponBase weapon)
    {
        equippedWeaponRight = weapon;
    }
    public WeaponBase GetRightWeapon()
    {
        return equippedWeaponRight;
    }
    public void SetLeftWeapon(WeaponBase weapon)
    {
        equippedWeaponLeft = weapon;
    }
    public WeaponBase GetLeftWeapon()
    {
        return equippedWeaponLeft;
    }
    public void SetArmour(ArmourBase armour)
    {
        if (armour.armourType == ArmourBase.ArmourTypes.Head)
        {
            equippedHeadArmour = armour;
        }
        else if (armour.armourType == ArmourBase.ArmourTypes.Chest)
        {
            equippedChestArmour = armour;
        }
        else if (armour.armourType == ArmourBase.ArmourTypes.Hand)
        {
            equippedHandArmour = armour;
        }
        else if (armour.armourType == ArmourBase.ArmourTypes.Leg)
        {
            equippedLegArmour = armour;
        }
        else if (armour.armourType == ArmourBase.ArmourTypes.Feet)
        {
            equippedFeetArmour = armour;
        }
    }
    public ArmourBase GetHeadArmour()
    {
        return equippedHeadArmour;
    }

    public ArmourBase GetChestArmour()
    {
        return equippedChestArmour;
    }

    public ArmourBase GetHandArmour()
    {
        return equippedHandArmour;
    }
    public ArmourBase GetLegArmour()
    {
        return equippedLegArmour;
    }
    public ArmourBase GetFeetArmour()
    {
        return equippedFeetArmour;
    }
}
