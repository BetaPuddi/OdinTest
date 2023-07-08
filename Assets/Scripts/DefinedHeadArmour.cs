using UnityEngine;

[CreateAssetMenu(fileName = "DefinedHeadArmour", menuName = "Armour/HeadArmour", order = 0)]
public class DefinedHeadArmour : ArmourBase
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