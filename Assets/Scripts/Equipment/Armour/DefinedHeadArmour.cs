using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//[CreateAssetMenu(fileName = "DefinedHeadArmour", menuName = "Armour/HeadArmour", order = 0)]
public class DefinedHeadArmour : ArmourBase
{
    //! Class not currently used.
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
}