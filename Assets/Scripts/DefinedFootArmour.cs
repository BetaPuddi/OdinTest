using UnityEngine;

[CreateAssetMenu(fileName = "DefinedFootArmour", menuName = "Armour/FootArmour", order = 0)]
public class DefinedFootArmour : ArmourBase
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