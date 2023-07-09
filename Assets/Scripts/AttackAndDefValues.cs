using UnityEngine;
using System.Collections;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "AttackAndDefValues", menuName = "Attributes and Resources/AttackAndDefValues", order = 0)]
public class AttackAndDefValues : ScriptableObject
{
    public int attackValue;
    public int defenseValue;
}