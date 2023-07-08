using UnityEngine;

[CreateAssetMenu(fileName = "DefinedFeetArmour", menuName = "Armour/FeetArmour", order = 0)]
public class DefinedFeetArmour : ArmourBase
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