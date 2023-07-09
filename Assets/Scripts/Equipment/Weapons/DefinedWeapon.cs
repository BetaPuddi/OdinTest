using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "DefinedWeapon", menuName = "New Weapon/DefinedWeapon", order = 0)]
public class DefinedWeapon : WeaponBase
{
    private void OnEnable()
    {
        //materialsMaxHealth = CalculateMaterialResources();
        //weaponTypeMaxHealth = CalculateWeaponTypeResources();
        //totalMaxHealth = CalculateWeaponResourcesTotals();
    }

    // Calculate resources
    public override int CalculateMaterialMaxHealth()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialResourceValues.maxHealth;
        }

        return total;
    }

    public override int CalculateMaterialMaxMana()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialResourceValues.maxMana;
        }
        return total;
    }

    public override int CalculateMaterialMaxStamina()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialResourceValues.maxStamina;
        }
        return total;
    }

    public override int CalculateMaterialMaxEnergy()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialResourceValues.maxEnergy;
        }
        return total;
    }

    public override int CalculateMaterialMaxMagic()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialResourceValues.maxMagic;
        }
        return total;
    }

    public override int CalculateWeaponTypeMaxHealth()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxHealth;
        }
        return total;
    }

    public override int CalculateWeaponTypeMaxMana()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxMana;
        }
        return total;
    }

    public override int CalculateWeaponTypeMaxStamina()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxStamina;
        }
        return total;
    }

    public override int CalculateWeaponTypeMaxEnergy()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeResourceValues.maxEnergy;
        }
        return total;
    }

    public override int CalculateWeaponTypeMaxMagic()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
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
    public override int CalculateMaterialStrength()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.strengthAtt;
        }
        return total;
    }

    public override int CalculateMaterialDexterity()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.dexterityAtt;
        }
        return total;
    }

    public override int CalculateMaterialConstitution()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.constitutionAtt;
        }
        return total;
    }

    public override int CalculateMaterialIntelligence()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.intelligenceAtt;
        }
        return total;
    }

    public override int CalculateMaterialWisdom()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.wisdomAtt;
        }
        return total;
    }

    public override int CalculateMaterialFocus()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.focusAtt;
        }
        return total;
    }

    public override int CalculateMaterialCharisma()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.charismaAtt;
        }
        return total;
    }

    public override int CalculateMaterialLuck()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.luckAtt;
        }
        return total;
    }

    public override int CalculateMaterialMind()
    {
        int total = 0;
        for (int i = 0; i < materials.Count; i++)
        {
            total += this.materials[i].materialAttributeValues.mindAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeStrength()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.strengthAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeDexterity()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.dexterityAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeConstitution()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.constitutionAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeIntelligence()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.intelligenceAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeWisdom()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.wisdomAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeFocus()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.focusAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeCharisma()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.charismaAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeLuck()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.luckAtt;
        }
        return total;
    }

    public override int CalculateWeaponTypeMind()
    {
        int total = 0;
        for (int i = 0; i < weaponType.Count; i++)
        {
            total += this.weaponType[i].weaponTypeAttributeValues.mindAtt;
        }
        return total;
    }
}