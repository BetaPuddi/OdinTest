using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public string abilityName;
    public string abilityDescription;
    public List<DamageType> damageTypes;
    public List<ElementType> elementTypes;
    public Entity target;
    public int damageValue;
    public int healValue;
    public float chargeTime;
    public float cooldownTime;
    public abstract void ExecuteAbility();

}