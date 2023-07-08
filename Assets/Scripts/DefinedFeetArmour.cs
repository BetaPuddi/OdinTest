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

    public int CalculateMaterialMaxMana()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialStatValues.maxMana;
        }
        return total;
    }

    public int CalculateMaterialMaxStamina()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialStatValues.maxStamina;
        }
        return total;
    }

    public int CalculateMaterialMaxEnergy()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialStatValues.maxEnergy;
        }
        return total;
    }

    public int CalculateMaterialMaxMagic()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialStatValues.maxMagic;
        }
        return total;
    }
}