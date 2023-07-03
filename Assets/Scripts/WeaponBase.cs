using System.Collections.Generic;
using UnityEngine;
using System.Collections;

// Base class for all weapons
public abstract class WeaponBase : ScriptableObject
{
    //Name of the weapon
    public string weaponName;
    //Description of the weapon
    public string description;

    //Type of the weapon
	public WeaponType[] weaponType;
    //Range of the weapon - Close, Mid, Long
    public string range;

    //How much the weapon costs
    public int value;

    //What the weapon is made of
	public ComponentMaterial[] materials;
    //Damage types of the weapon - Physical, Magical, Ethereal
    public DamageType[] damageTypes;
    //Element types of the weapon
    public ElementType[] elements;
    //Attribute values of the weapon - Strength, Dexterity etc
    public AttributeValues attributeValues;
    //Stat values of the weapon - Attack, Defense, Speed, etc
    public StatValues statValues;
    //Passive effects of the weapon - Can be passed on from materials
    public Passive[] passives;
    //Replaces the attack command - can be null
    public Action attackReplacement;

    /*public Weapon(string name, string description, WeaponType type, string range, int value, Material[] materials, DamageType[] damageTypes, ElementType[] elements, AttributeValues attributeValues, StatValues statValues, Passive[] passives, Action attackReplacement)
    {
        this.name = name;
        this.description = description;
        this.type = type;
        this.range = range;
        this.value = value;
        this.materials = materials;
        this.damageTypes = damageTypes;
        this.elements = elements;
        this.attributeValues = attributeValues;
        this.statValues = statValues;
        this.passives = passives;
        this.attackReplacement = attackReplacement;
    }*/
}