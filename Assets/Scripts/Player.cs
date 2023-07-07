﻿using System.Collections;
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
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialStats() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeStats();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialStats() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeStats();
        return total;
    }
}
