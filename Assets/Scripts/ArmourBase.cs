using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmourBase : ScriptableObject
{
    public string armourName;
    public string armourDescription;
    public ArmourType armourType;
    public int armourPrice;

    public ComponentMaterial[] materials;
    public DamageType[] damageTypes;
    public ElementType[] elements;
    public AttackAndDefValues attackAndDefValues;
    public AttributeValues attributeValues;
    public StatValues statValues;
    public Passive[] passives;
}
