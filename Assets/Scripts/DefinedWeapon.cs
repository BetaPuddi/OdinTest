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
        materialsMaxHealth = CalculateMaterialStats();
        weaponTypeMaxHealth = CalculateWeaponTypeStats();
        totalMaxHealth = CalculateWeaponStatsTotals();
    }

    public int CalculateMaterialStats()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialStatValues.maxHealth;
        }

        return total;
    }

    public int CalculateWeaponTypeStats()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeStatValues.maxHealth;
        }
        return total;
    }

    public int CalculateWeaponStatsTotals()
    {
        int total = this.statValues.maxHealth + this.materialsMaxHealth + this.weaponTypeMaxHealth;
        return total;
    }
}