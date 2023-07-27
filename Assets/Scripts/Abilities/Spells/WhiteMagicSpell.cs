using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WhiteMagicSpell", menuName = "Ability/Spell/White Magic", order = 0)]
public class WhiteMagicSpell : Spell
{
    public List<AbilityAction> actions;
    public override void ExecuteAbility()
    {
        foreach (AbilityAction action in actions)
        {
            action.Execute(this.damageValue, this.target);
        }
    }
}