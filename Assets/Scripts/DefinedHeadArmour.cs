using UnityEngine;

[CreateAssetMenu(fileName = "DefinedHeadArmour", menuName = "Armour/HeadArmour", order = 0)]
public class DefinedHeadArmour : ArmourBase
{
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
}