using System;
using UnityEngine;

public class Enemy : Entity
{
    void Start()
    {
        this.entityInventory = this.GetComponent<Inventory>();
    }
}