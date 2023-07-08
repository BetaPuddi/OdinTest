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

    // Calculate resources
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

    // Attribute calculations
    public int CalculateMaterialStrength()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.strengthAtt;
        }
        return total;
    }

    public int CalculateMaterialDexterity()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.dexterityAtt;
        }
        return total;
    }

    public int ClculateMaterialConstitution()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.constitutionAtt;
        }
        return total;
    }

    public int CalculateMaterialIntelligence()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.intelligenceAtt;
        }
        return total;
    }

    public int CalculateMaterialWisdom()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.wisdomAtt;
        }
        return total;
    }

    public int CalculateMaterialFocus()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.focusAtt;
        }
        return total;
    }

    public int CalculateMaterialCharisma()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.charismaAtt;
        }
        return total;
    }

    public int CalculateMaterialLuck()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.luckAtt;
        }
        return total;
    }

    public int CalculateMaterialMind()
    {
        int total = 0;
        for (int i = 0; i < materials.Length; i++)
        {
            total += this.materials[i].materialAttributeValues.mindAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeStrength()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.strengthAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeDexterity()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.dexterityAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeConstitution()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.constitutionAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeIntelligence()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.intelligenceAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeWisdom()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.wisdomAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeFocus()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.focusAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeCharisma()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.charismaAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeLuck()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.luckAtt;
        }
        return total;
    }

    public int CalculateWeaponTypeMind()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Length; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.mindAtt;
        }
        return total;
    }
}