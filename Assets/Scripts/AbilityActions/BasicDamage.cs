using UnityEngine;
using System.Collections;

[System.Serializable]
[CreateAssetMenu(fileName = "BasicDamage", menuName = "Ability Actions/Damage/Basic Damage")]
public class BasicDamage : AbilityAction
{
    public override void Execute(int damage, Entity target)
    {
        DealDamage(damage, target);
    }
    public void DealDamage(int abilityDamage, Entity target)
    {
        target.currentHealth -= abilityDamage;
    }
}