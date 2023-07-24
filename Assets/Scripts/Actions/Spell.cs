using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "Ability/Spell", order = 0)]
public class Spell : Ability
{
    public enum SpellSchool
    {
        WhiteMagic,
        BlackMagic,
        GreenMagic
    }
    [SerializeField]
    public SpellSchool spellSchool;
    public override void ExecuteAbility()
    {

    }
}