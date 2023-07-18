using UnityEngine;

[CreateAssetMenu(fileName = "ResourceValues", menuName = "Attributes and Resources/ResourceValues", order = 0)]
public class ResourceValues : ScriptableObject
{
    public int maxHealth;
    public int maxMana;
    public int maxStamina;
    public int maxEnergy;
    public int maxMagic;

}