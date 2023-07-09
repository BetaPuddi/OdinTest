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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
