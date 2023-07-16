using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
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
    public abstract int CalculateEntityMaxHealthFromWeapons();
    public abstract int CalculateEntityMaxManaFromWeapons();
    public abstract int CalculateEntityMaxStaminaFromWeapons();
    public abstract int CalculateEntityMaxEnergyFromWeapons();
    public abstract int CalculateEntityMaxMagicFromWeapons();
    public abstract int CalculateEntityMaxHealthFromArmour();
    public abstract int CalculateEntityMaxManaFromArmour();
    public abstract int CalculateEntityMaxStaminaFromArmour();
    public abstract int CalculateEntityMaxEnergyFromArmour();
    public abstract int CalculateEntityMaxMagicFromArmour();
    public abstract int CalculateEntityStrengthFromWeapons();
    public abstract int CalculateEntityDexterityFromWeapons();
    public abstract int CalculateEntityConstitutionFromWeapons();
    public abstract int CalculateEntityIntelligenceFromWeapons();
    public abstract int CalculateEntityWisdomFromWeapons();
    public abstract int CalculateEntityFocusFromWeapons();
    public abstract int CalculateEntityCharismaFromWeapons();
    public abstract int CalculateEntityLuckFromWeapons();
    public abstract int CalculateEntityMindFromWeapons();
    public abstract int CalculateEntityStrengthFromArmour();
    public abstract int CalculateEntityDexterityFromArmour();
    public abstract int CalculateEntityConstitutionFromArmour();
    public abstract int CalculateEntityIntelligenceFromArmour();
    public abstract int CalculateEntityWisdomFromArmour();
    public abstract int CalculateEntityFocusFromArmour();
    public abstract int CalculateEntityCharismaFromArmour();
    public abstract int CalculateEntityLuckFromArmour();
    public abstract int CalculateEntityMindFromArmour();
}
