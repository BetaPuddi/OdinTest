using UnityEngine;
using System.Collections;

public abstract class AbilityAction : ScriptableObject
{
    public abstract void Execute(int damage, Entity target);
}