using UnityEngine;
using System.Collections;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "DefinedWeapon", menuName = "New Weapon/DefinedWeapon", order = 0)]
public class DefinedWeapon : WeaponBase
{
    public int totalMaxHealth;
    public int weaponTypeMaxHealth;
    public int materialsMaxHealth;

    private void OnEnable()
    {
        //materialsMaxHealth = CalculateMaterialStats();
        //weaponTypeMaxHealth = CalculateWeaponTypeStats();
        //totalMaxHealth = CalculateWeaponStatsTotals();
    }

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

    public int CalculateWeaponTypeMaxHealth()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeStatValues.maxHealth;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxMana()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeStatValues.maxMana;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxStamina()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeStatValues.maxStamina;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxEnergy()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeStatValues.maxEnergy;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxMagic()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeStatValues.maxMagic;
        }
        return total;
    }

    /*public int CalculateWeaponStatsTotals()
    {
        int total = this.statValues.maxHealth + this.materialsMaxHealth + this.weaponTypeMaxHealth;
        return total;
    }*/
}