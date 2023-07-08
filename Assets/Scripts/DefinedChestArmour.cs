using UnityEngine;

[CreateAssetMenu(fileName = "DefinedChestArmour", menuName = "Armour/ChestArmour", order = 0)]
public class DefinedChestArmour : ArmourBase
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