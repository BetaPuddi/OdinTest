using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
[CreateAssetMenu(fileName = "EnemyInventory", menuName = "Defined Inventory/Enemy Inventory", order = 0)]
public class EnemyInventory : ScriptableObject
{
    public delegate void UpdateUI();
    public static event UpdateUI OnUpdateUI;
    public WeaponBase equippedWeaponRight = null;
    public WeaponBase equippedWeaponLeft = null;
    public ArmourBase equippedHeadArmour = null;
    public ArmourBase equippedChestArmour = null;
    public ArmourBase equippedHandArmour = null;
    public ArmourBase equippedLegArmour = null;
    public ArmourBase equippedFeetArmour = null;
    private WeaponBase blankWeapon;
    private ArmourBase blankArmour;

    public List<InventoryItem> equippedItems = new List<InventoryItem>();
    public List<InventoryItem> inventoryItems = new List<InventoryItem>();

    private void OnValidate()
    {
        UpdateEquippedList();
    }
    void Start()
    {
        UpdateEquippedList();
        /*var emptyItemAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/items/empty");
        emptyWeapon = emptyItemAssetBundle.LoadAsset<WeaponBase>("EmptyWeapon");
        emptyArmour = emptyItemAssetBundle.LoadAsset<ArmourBase>("EmptyArmour");*/
    }
    public void UpdateEquippedList()
    {
        equippedItems.Clear();
        equippedItems.Insert(0, equippedWeaponRight as InventoryItem);
        equippedItems.Insert(1, equippedWeaponLeft as InventoryItem);
        equippedItems.Insert(2, equippedHeadArmour as InventoryItem);
        equippedItems.Insert(3, equippedChestArmour as InventoryItem);
        equippedItems.Insert(4, equippedHandArmour as InventoryItem);
        equippedItems.Insert(5, equippedLegArmour as InventoryItem);
        equippedItems.Insert(6, equippedFeetArmour as InventoryItem);
    }
    [ContextMenu("Sort Inventory Items")]
    public void SortInventoryItems()
    {
        inventoryItems = inventoryItems.OrderBy(x => x.sortingPosition).ToList();
    }
    public void AddItem(InventoryItem item)
    {
        inventoryItems.Add(item);
        SortInventoryItems();
        if (OnUpdateUI != null)
        {
            OnUpdateUI();
        }
    }
    public void RemoveItem(InventoryItem item)
    {
        inventoryItems.Remove(item);
        SortInventoryItems();
        if (OnUpdateUI != null)
        {
            OnUpdateUI();
        }
    }
    public void RemoveAllItems()
    {
        inventoryItems.Clear();
        if (OnUpdateUI != null)
        {
            OnUpdateUI();
        }
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
        if (equippedWeaponRight.itemName != "Empty")
        {
            AddItem(equippedWeaponRight);
        }
        equippedWeaponRight = weapon;
        if (OnUpdateUI != null)
        {
            OnUpdateUI();
        }
        UpdateEquippedList();
    }
    public WeaponBase GetRightWeapon()
    {
        return equippedWeaponRight;
    }
    public void SetLeftWeapon(WeaponBase weapon)
    {
        if (equippedWeaponLeft.itemName != "Empty")
        {
            AddItem(equippedWeaponLeft);
        }
        equippedWeaponLeft = weapon;
        if (OnUpdateUI != null)
        {
            OnUpdateUI();
        }
        UpdateEquippedList();
    }
    public WeaponBase GetLeftWeapon()
    {
        return equippedWeaponLeft;
    }
    public void SetArmour(ArmourBase armour)
    {
        if (armour.armourType == ArmourBase.ArmourTypes.Head)
        {
            if (equippedHeadArmour.itemName != "Empty")
            {
                AddItem(equippedHeadArmour);
            }
            equippedHeadArmour = armour;
        }
        else if (armour.armourType == ArmourBase.ArmourTypes.Chest)
        {
            if (equippedChestArmour.itemName != "Empty")
            {
                AddItem(equippedChestArmour);
            }
            equippedChestArmour = armour;
        }
        else if (armour.armourType == ArmourBase.ArmourTypes.Hands)
        {
            if (equippedHandArmour.itemName != "Empty")
            {
                AddItem(equippedHandArmour);
            }
            equippedHandArmour = armour;
        }
        else if (armour.armourType == ArmourBase.ArmourTypes.Legs)
        {
            if (equippedLegArmour.itemName != "Empty")
            {
                AddItem(equippedLegArmour);
            }
            equippedLegArmour = armour;
        }
        else if (armour.armourType == ArmourBase.ArmourTypes.Feet)
        {
            if (equippedFeetArmour.itemName != "Empty")
            {
                AddItem(equippedFeetArmour);
            }
            equippedFeetArmour = armour;
        }
        if (OnUpdateUI != null)
        {
            OnUpdateUI();
        }
        UpdateEquippedList();
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
    public void UnequipItem(int index)
    {
        blankWeapon = ResourceBundleManager.Instance.blankItemAssetBundle.LoadAsset<WeaponBase>("EmptyWeapon");
        blankArmour = ResourceBundleManager.Instance.blankItemAssetBundle.LoadAsset<ArmourBase>("EmptyArmour");
        equippedItems[index] = null;
        if (index == 0)
        {
            equippedWeaponRight = blankWeapon;
        }
        else if (index == 1)
        {
            equippedWeaponLeft = blankWeapon;
        }
        else if (index == 2)
        {
            equippedHeadArmour = blankArmour;
        }
        else if (index == 3)
        {
            equippedChestArmour = blankArmour;
        }
        else if (index == 4)
        {
            equippedHandArmour = blankArmour;
        }
        else if (index == 5)
        {
            equippedLegArmour = blankArmour;
        }
        else if (index == 6)
        {
            equippedFeetArmour = blankArmour;
        }
        UpdateEquippedList();
        if (OnUpdateUI != null)
        {
            OnUpdateUI();
        }
    }
}
