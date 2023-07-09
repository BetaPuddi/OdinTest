using UnityEngine;

[CreateAssetMenu(fileName = "WeaponType", menuName = "Types/WeaponType", order = 0)]
public class WeaponType : ScriptableObject
{
    public string typeName;
    public ResourceValues weaponTypeResourceValues;
    public AttributeValues weaponTypeAttributeValues;
}