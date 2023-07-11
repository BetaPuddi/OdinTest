using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    // STAT VALUES
    public int maxHealth;
    public int currentHealth;
    public int maxMana;
    public int currentMana;
    public int maxStamina;
    public int currentStamina;
    public int maxEnergy;
    public int currentEnergy;
    public int maxMagic;
    public int currentMagic;

    // ATTRIBUTE VALUES
    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int focus;
    public int charisma;
    public int luck;
    public int mind;

    public Inventory entityInventory;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }
}
