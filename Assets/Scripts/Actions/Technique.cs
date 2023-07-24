using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Technique", menuName = "Ability/Technique", order = 0)]
public class Technique : Ability
{
    public enum TechniqueSchool
    {
        Chivalry,
        MartialArts,
        Archery
    }
    [SerializeField]
    public TechniqueSchool techniqueSchool;
    public override void ExecuteAbility()
    {

    }
}