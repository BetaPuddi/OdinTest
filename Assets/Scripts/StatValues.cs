using UnityEngine;

[CreateAssetMenu(fileName = "StatValues", menuName = "Attributes and Stats/StatValues", order = 0)]
public class StatValues : ScriptableObject
{
    public int maxHealth;
    public int maxMana;
    public int maxStamina;
    public int maxEnergy;
    public int maxMagic;

}