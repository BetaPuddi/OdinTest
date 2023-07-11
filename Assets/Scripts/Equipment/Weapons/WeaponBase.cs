using System.Collections.Generic;
using UnityEngine;
using System.Collections;

// Base class for all weapons
public abstract class WeaponBase : InventoryItem
{
    //Description of the weapon
    public string description;

    //Type of the weapon
    public List<WeaponType> weaponType = new List<WeaponType>();
    //Range of the weapon - Close, Mid, Long
    public enum WeaponRange
    {
        Close,
        Mid,
        Long
    }
    public WeaponRange range;
    //How much the weapon costs
    public int weaponPrice;

    //What the weapon is made of
    public List<ComponentMaterial> materials = new List<ComponentMaterial>();
    //Damage types of the weapon - Physical, Magical, Ethereal
    public List<DamageType> damageTypes = new List<DamageType>();
    //Element types of the weapon
    public List<ElementType> elements = new List<ElementType>();
    //The attack and defense values of the weapon
    public AttackAndDefValues attackAndDefValues;
    //Attribute values of the weapon - Strength, Dexterity etc
    public AttributeValues attributeValues;
    //resource values of the weapon - Attack, Defense, Speed, etc
    public ResourceValues resourceValues;
    //Passive effects of the weapon - Can be passed on from materials
    public List<Passive> passives = new List<Passive>();
    //Replaces the attack command - can be null
    public Action attackReplacement;

    public abstract int CalculateMaterialMaxHealth();
    public abstract int CalculateMaterialMaxMana();
    public abstract int CalculateMaterialMaxStamina();
    public abstract int CalculateMaterialMaxEnergy();
    public abstract int CalculateMaterialMaxMagic();

    public abstract int CalculateWeaponTypeMaxHealth();
    public abstract int CalculateWeaponTypeMaxMana();
    public abstract int CalculateWeaponTypeMaxStamina();
    public abstract int CalculateWeaponTypeMaxEnergy();
    public abstract int CalculateWeaponTypeMaxMagic();

    public abstract int CalculateMaterialStrength();
    public abstract int CalculateMaterialDexterity();
    public abstract int CalculateMaterialConstitution();
    public abstract int CalculateMaterialIntelligence();
    public abstract int CalculateMaterialWisdom();
    public abstract int CalculateMaterialFocus();
    public abstract int CalculateMaterialCharisma();
    public abstract int CalculateMaterialLuck();
    public abstract int CalculateMaterialMind();

    public abstract int CalculateWeaponTypeStrength();
    public abstract int CalculateWeaponTypeDexterity();
    public abstract int CalculateWeaponTypeConstitution();
    public abstract int CalculateWeaponTypeIntelligence();
    public abstract int CalculateWeaponTypeWisdom();
    public abstract int CalculateWeaponTypeFocus();
    public abstract int CalculateWeaponTypeCharisma();
    public abstract int CalculateWeaponTypeLuck();
    public abstract int CalculateWeaponTypeMind();
}