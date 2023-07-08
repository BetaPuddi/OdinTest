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


}