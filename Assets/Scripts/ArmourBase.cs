using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArmourBase : InventoryItem
{
    public string armourName;
    public string armourDescription;
    //public ArmourType armourType;
    public int armourPrice;

    public List<ComponentMaterial> materials = new List<ComponentMaterial>();
    public List<DamageType> damageTypes = new List<DamageType>();
    public List<ElementType> elements = new List<ElementType>();
    public AttackAndDefValues attackAndDefValues;
    public AttributeValues attributeValues;
    public ResourceValues resourceValues;
    public List<Passive> passives = new List<Passive>();

    public abstract int CalculateMaterialMaxHealth();
    public abstract int CalculateMaterialMaxMana();
    public abstract int CalculateMaterialMaxStamina();
    public abstract int CalculateMaterialMaxEnergy();
    public abstract int CalculateMaterialMaxMagic();

    public abstract int CalculateMaterialStrength();
    public abstract int CalculateMaterialDexterity();
    public abstract int CalculateMaterialConstitution();
    public abstract int CalculateMaterialIntelligence();
    public abstract int CalculateMaterialWisdom();
    public abstract int CalculateMaterialFocus();
    public abstract int CalculateMaterialCharisma();
    public abstract int CalculateMaterialLuck();
    public abstract int CalculateMaterialMind();
}
