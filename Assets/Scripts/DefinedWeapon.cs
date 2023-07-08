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
        //materialsMaxHealth = CalculateMaterialResources();
        //weaponTypeMaxHealth = CalculateWeaponTypeResources();
        //totalMaxHealth = CalculateWeaponResourcesTotals();
    }

    public int CalculateMaterialMaxHealth()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialResourceValues.maxHealth;
        }

        return total;
    }

    public int CalculateMaterialMaxMana()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialResourceValues.maxMana;
        }
        return total;
    }

    public int CalculateMaterialMaxStamina()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialResourceValues.maxStamina;
        }
        return total;
    }

    public int CalculateMaterialMaxEnergy()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialResourceValues.maxEnergy;
        }
        return total;
    }

    public int CalculateMaterialMaxMagic()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialResourceValues.maxMagic;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxHealth()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxHealth;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxMana()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxMana;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxStamina()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxStamina;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxEnergy()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxEnergy;
        }
        return total;
    }

    public int CalculateWeaponTypeMaxMagic()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxMagic;
        }
        return total;
    }

    /*public int CalculateWeaponResourcesTotals()
    {
        int total = this.ResourceValues.maxHealth + this.materialsMaxHealth + this.weaponTypeMaxHealth;
        return total;
    }*/
}