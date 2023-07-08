using UnityEngine;

[CreateAssetMenu(fileName = "DefinedHandArmour", menuName = "Armour/HandArmour", order = 0)]
public class DefinedHandArmour : ArmourBase
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