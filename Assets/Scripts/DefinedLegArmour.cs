using UnityEngine;

[CreateAssetMenu(fileName = "DefinedLegArmour", menuName = "Armour/LegArmour", order = 0)]
public class DefinedLegArmour : ArmourBase
{
    public int CalculateMaterialMaxHealth()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialStatValues.maxHealth;
        }

        return total;
    }
}