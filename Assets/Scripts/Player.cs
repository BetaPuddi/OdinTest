using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{


    // Start is called before the first frame update
    void Start()
    {
        this.entityInventory = this.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        this.maxHealth = CalculatePlayerMaxHealthFromWeapons();
    }

    public int CalculatePlayerMaxHealthFromWeapons()
    {
        int total = 0;
        if (UnityEngine.Object.ReferenceEquals(null, this.entityInventory.equippedWeaponRight))
        {
            total = this.entityInventory.equippedWeaponRight.CalculateMaterialStats() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeStats();
        }
        if (UnityEngine.Object.ReferenceEquals(null, this.entityInventory.equippedWeaponLeft))
        {
            total += this.entityInventory.equippedWeaponLeft.CalculateMaterialStats() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeStats();
        }
        return total;
    }
}
