using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    public int playerMaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        this.entityInventory = this.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMaxHealth = CalculatePlayerMaxHealthFromWeapon();
    }

    public int CalculatePlayerMaxHealthFromWeapon()
    {
        int total = 0;
        total = this.entityInventory.equippedWeapon.CalculateMaterialStats() + this.entityInventory.equippedWeapon.CalculateWeaponTypeStats();
        return total;
    }
}
