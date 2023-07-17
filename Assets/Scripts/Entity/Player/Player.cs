using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // Inherits stats and name from Entity
    void Start()
    {
        this.entityInventory = this.GetComponent<Inventory>();// Get the inventory component attached to the game object

        // TODO: Replace current health initialization
        this.currentHealth = this.maxHealth;
        this.currentMana = this.maxMana;
        this.currentStamina = this.maxStamina;
        this.currentEnergy = this.maxEnergy;
        this.currentMagic = this.maxMagic;
    }

    // Update is called once per frame
    void Update()
    {
        // These set all the stats for the enemy from the weapon and armour scriptable objects 
        this.maxHealth = CalculateEntityMaxHealthFromWeapons() + CalculateEntityMaxHealthFromArmour();
        this.maxMana = CalculateEntityMaxManaFromWeapons() + CalculateEntityMaxManaFromArmour();
        this.maxStamina = CalculateEntityMaxStaminaFromWeapons() + CalculateEntityMaxStaminaFromArmour();
        this.maxEnergy = CalculateEntityMaxEnergyFromWeapons() + CalculateEntityMaxEnergyFromArmour();
        this.maxMagic = CalculateEntityMaxMagicFromWeapons() + CalculateEntityMaxMagicFromArmour();

        this.strength = CalculateEntityStrengthFromWeapons() + CalculateEntityStrengthFromArmour();
        this.dexterity = CalculateEntityDexterityFromWeapons() + CalculateEntityDexterityFromArmour();
        this.constitution = CalculateEntityConstitutionFromWeapons() + CalculateEntityConstitutionFromArmour();
        this.intelligence = CalculateEntityIntelligenceFromWeapons() + CalculateEntityIntelligenceFromArmour();
        this.wisdom = CalculateEntityWisdomFromWeapons() + CalculateEntityWisdomFromArmour();
        this.focus = CalculateEntityFocusFromWeapons() + CalculateEntityFocusFromArmour();
        this.charisma = CalculateEntityCharismaFromWeapons() + CalculateEntityCharismaFromArmour();
        this.luck = CalculateEntityLuckFromWeapons() + CalculateEntityLuckFromArmour();
        this.mind = CalculateEntityMindFromWeapons() + CalculateEntityMindFromArmour();
    }

    /** Resource Calculations
    * These two sections calculate the stats from the weapon and armour scriptable objects' materials, types, and extra scriptable objects
    * Resources are calculated first, then the attributes
    */
    // Resource Calculations
    #region Resource Calculations
    public override int CalculateEntityMaxHealthFromWeapons()
    {
        int total = 0;

        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxHealth() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxHealth() + this.entityInventory.equippedWeaponRight.resourceValues.maxHealth;

        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxHealth() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxHealth() + this.entityInventory.equippedWeaponLeft.resourceValues.maxHealth;

        return total;
    }

    public override int CalculateEntityMaxManaFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxMana() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxMana() + this.entityInventory.equippedWeaponRight.resourceValues.maxMana;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxMana() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxMana() + this.entityInventory.equippedWeaponLeft.resourceValues.maxMana;
        return total;
    }

    public override int CalculateEntityMaxStaminaFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxStamina() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxStamina() + this.entityInventory.equippedWeaponRight.resourceValues.maxStamina;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxStamina() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxStamina() + this.entityInventory.equippedWeaponLeft.resourceValues.maxStamina;
        return total;
    }

    public override int CalculateEntityMaxEnergyFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxEnergy() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxEnergy() + this.entityInventory.equippedWeaponRight.resourceValues.maxEnergy;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxEnergy() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxEnergy() + this.entityInventory.equippedWeaponLeft.resourceValues.maxEnergy;
        return total;
    }

    public override int CalculateEntityMaxMagicFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxMagic() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxMagic() + this.entityInventory.equippedWeaponRight.resourceValues.maxMagic;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxMagic() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxMagic() + this.entityInventory.equippedWeaponLeft.resourceValues.maxMagic;
        return total;
    }

    public override int CalculateEntityMaxHealthFromArmour()
    {
        int total = 0;

        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxHealth() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxHealth() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxHealth() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxHealth() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxHealth();
        total += this.entityInventory.equippedHeadArmour.resourceValues.maxHealth + this.entityInventory.equippedChestArmour.resourceValues.maxHealth + this.entityInventory.equippedHandArmour.resourceValues.maxHealth + this.entityInventory.equippedLegArmour.resourceValues.maxHealth + this.entityInventory.equippedFeetArmour.resourceValues.maxHealth;

        return total;
    }

    public override int CalculateEntityMaxManaFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxMana() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxMana() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxMana() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxMana() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxMana();
        total += this.entityInventory.equippedHeadArmour.resourceValues.maxMana + this.entityInventory.equippedChestArmour.resourceValues.maxMana + this.entityInventory.equippedHandArmour.resourceValues.maxMana + this.entityInventory.equippedLegArmour.resourceValues.maxMana + this.entityInventory.equippedFeetArmour.resourceValues.maxMana;
        return total;
    }

    public override int CalculateEntityMaxStaminaFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxStamina() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxStamina() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxStamina() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxStamina() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxStamina();
        total += this.entityInventory.equippedHeadArmour.resourceValues.maxStamina + this.entityInventory.equippedChestArmour.resourceValues.maxStamina + this.entityInventory.equippedHandArmour.resourceValues.maxStamina + this.entityInventory.equippedLegArmour.resourceValues.maxStamina + this.entityInventory.equippedFeetArmour.resourceValues.maxStamina;
        return total;
    }

    public override int CalculateEntityMaxEnergyFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxEnergy() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxEnergy() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxEnergy() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxEnergy() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxEnergy();
        total += this.entityInventory.equippedHeadArmour.resourceValues.maxEnergy + this.entityInventory.equippedChestArmour.resourceValues.maxEnergy + this.entityInventory.equippedHandArmour.resourceValues.maxEnergy + this.entityInventory.equippedLegArmour.resourceValues.maxEnergy + this.entityInventory.equippedFeetArmour.resourceValues.maxEnergy;
        return total;
    }

    public override int CalculateEntityMaxMagicFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxMagic() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxMagic() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxMagic() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxMagic() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxMagic();
        total += this.entityInventory.equippedHeadArmour.resourceValues.maxMagic + this.entityInventory.equippedChestArmour.resourceValues.maxMagic + this.entityInventory.equippedHandArmour.resourceValues.maxMagic + this.entityInventory.equippedLegArmour.resourceValues.maxMagic + this.entityInventory.equippedFeetArmour.resourceValues.maxMagic;
        return total;
    }
    #endregion

    // Attribute Calculations
    #region Attribute Calculations
    public override int CalculateEntityStrengthFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialStrength() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeStrength() + this.entityInventory.equippedWeaponRight.attributeValues.strengthAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialStrength() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeStrength() + this.entityInventory.equippedWeaponLeft.attributeValues.strengthAtt;
        return total;
    }

    public override int CalculateEntityDexterityFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialDexterity() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeDexterity() + this.entityInventory.equippedWeaponRight.attributeValues.dexterityAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialDexterity() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeDexterity() + this.entityInventory.equippedWeaponLeft.attributeValues.dexterityAtt;
        return total;
    }

    public override int CalculateEntityConstitutionFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialConstitution() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeConstitution() + this.entityInventory.equippedWeaponRight.attributeValues.constitutionAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialConstitution() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeConstitution() + this.entityInventory.equippedWeaponLeft.attributeValues.constitutionAtt;
        return total;
    }

    public override int CalculateEntityIntelligenceFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialIntelligence() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeIntelligence() + this.entityInventory.equippedWeaponRight.attributeValues.intelligenceAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialIntelligence() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeIntelligence() + this.entityInventory.equippedWeaponLeft.attributeValues.intelligenceAtt;
        return total;
    }

    public override int CalculateEntityWisdomFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialWisdom() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeWisdom() + this.entityInventory.equippedWeaponRight.attributeValues.wisdomAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialWisdom() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeWisdom() + this.entityInventory.equippedWeaponLeft.attributeValues.wisdomAtt;
        return total;
    }

    public override int CalculateEntityFocusFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialFocus() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeFocus() + this.entityInventory.equippedWeaponRight.attributeValues.focusAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialFocus() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeFocus() + this.entityInventory.equippedWeaponLeft.attributeValues.focusAtt;
        return total;
    }

    public override int CalculateEntityCharismaFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialCharisma() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeCharisma() + this.entityInventory.equippedWeaponRight.attributeValues.charismaAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialCharisma() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeCharisma() + this.entityInventory.equippedWeaponLeft.attributeValues.charismaAtt;
        return total;
    }

    public override int CalculateEntityLuckFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialLuck() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeLuck() + this.entityInventory.equippedWeaponRight.attributeValues.luckAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialLuck() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeLuck() + this.entityInventory.equippedWeaponLeft.attributeValues.luckAtt;
        return total;
    }

    public override int CalculateEntityMindFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMind() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMind() + this.entityInventory.equippedWeaponRight.attributeValues.mindAtt;
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMind() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMind() + this.entityInventory.equippedWeaponLeft.attributeValues.mindAtt;
        return total;
    }

    public override int CalculateEntityStrengthFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialStrength() + this.entityInventory.equippedChestArmour.CalculateMaterialStrength() + this.entityInventory.equippedHandArmour.CalculateMaterialStrength() + this.entityInventory.equippedLegArmour.CalculateMaterialStrength() + this.entityInventory.equippedFeetArmour.CalculateMaterialStrength();
        total += this.entityInventory.equippedHeadArmour.attributeValues.strengthAtt + this.entityInventory.equippedChestArmour.attributeValues.strengthAtt + this.entityInventory.equippedHandArmour.attributeValues.strengthAtt + this.entityInventory.equippedLegArmour.attributeValues.strengthAtt + this.entityInventory.equippedFeetArmour.attributeValues.strengthAtt;
        return total;
    }

    public override int CalculateEntityDexterityFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialDexterity() + this.entityInventory.equippedChestArmour.CalculateMaterialDexterity() + this.entityInventory.equippedHandArmour.CalculateMaterialDexterity() + this.entityInventory.equippedLegArmour.CalculateMaterialDexterity() + this.entityInventory.equippedFeetArmour.CalculateMaterialDexterity();
        total += this.entityInventory.equippedHeadArmour.attributeValues.dexterityAtt + this.entityInventory.equippedChestArmour.attributeValues.dexterityAtt + this.entityInventory.equippedHandArmour.attributeValues.dexterityAtt + this.entityInventory.equippedLegArmour.attributeValues.dexterityAtt + this.entityInventory.equippedFeetArmour.attributeValues.dexterityAtt;
        return total;
    }

    public override int CalculateEntityConstitutionFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialConstitution() + this.entityInventory.equippedChestArmour.CalculateMaterialConstitution() + this.entityInventory.equippedHandArmour.CalculateMaterialConstitution() + this.entityInventory.equippedLegArmour.CalculateMaterialConstitution() + this.entityInventory.equippedFeetArmour.CalculateMaterialConstitution();
        total += this.entityInventory.equippedHeadArmour.attributeValues.constitutionAtt + this.entityInventory.equippedChestArmour.attributeValues.constitutionAtt + this.entityInventory.equippedHandArmour.attributeValues.constitutionAtt + this.entityInventory.equippedLegArmour.attributeValues.constitutionAtt + this.entityInventory.equippedFeetArmour.attributeValues.constitutionAtt;
        return total;
    }

    public override int CalculateEntityIntelligenceFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialIntelligence() + this.entityInventory.equippedChestArmour.CalculateMaterialIntelligence() + this.entityInventory.equippedHandArmour.CalculateMaterialIntelligence() + this.entityInventory.equippedLegArmour.CalculateMaterialIntelligence() + this.entityInventory.equippedFeetArmour.CalculateMaterialIntelligence();
        total += this.entityInventory.equippedHeadArmour.attributeValues.intelligenceAtt + this.entityInventory.equippedChestArmour.attributeValues.intelligenceAtt + this.entityInventory.equippedHandArmour.attributeValues.intelligenceAtt + this.entityInventory.equippedLegArmour.attributeValues.intelligenceAtt + this.entityInventory.equippedFeetArmour.attributeValues.intelligenceAtt;
        return total;
    }

    public override int CalculateEntityWisdomFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialWisdom() + this.entityInventory.equippedChestArmour.CalculateMaterialWisdom() + this.entityInventory.equippedHandArmour.CalculateMaterialWisdom() + this.entityInventory.equippedLegArmour.CalculateMaterialWisdom() + this.entityInventory.equippedFeetArmour.CalculateMaterialWisdom();
        total += this.entityInventory.equippedHeadArmour.attributeValues.wisdomAtt + this.entityInventory.equippedChestArmour.attributeValues.wisdomAtt + this.entityInventory.equippedHandArmour.attributeValues.wisdomAtt + this.entityInventory.equippedLegArmour.attributeValues.wisdomAtt + this.entityInventory.equippedFeetArmour.attributeValues.wisdomAtt;
        return total;
    }

    public override int CalculateEntityFocusFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialFocus() + this.entityInventory.equippedChestArmour.CalculateMaterialFocus() + this.entityInventory.equippedHandArmour.CalculateMaterialFocus() + this.entityInventory.equippedLegArmour.CalculateMaterialFocus() + this.entityInventory.equippedFeetArmour.CalculateMaterialFocus();
        total += this.entityInventory.equippedHeadArmour.attributeValues.focusAtt + this.entityInventory.equippedChestArmour.attributeValues.focusAtt + this.entityInventory.equippedHandArmour.attributeValues.focusAtt + this.entityInventory.equippedLegArmour.attributeValues.focusAtt + this.entityInventory.equippedFeetArmour.attributeValues.focusAtt;
        return total;
    }

    public override int CalculateEntityCharismaFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialCharisma() + this.entityInventory.equippedChestArmour.CalculateMaterialCharisma() + this.entityInventory.equippedHandArmour.CalculateMaterialCharisma() + this.entityInventory.equippedLegArmour.CalculateMaterialCharisma() + this.entityInventory.equippedFeetArmour.CalculateMaterialCharisma();
        total += this.entityInventory.equippedHeadArmour.attributeValues.charismaAtt + this.entityInventory.equippedChestArmour.attributeValues.charismaAtt + this.entityInventory.equippedHandArmour.attributeValues.charismaAtt + this.entityInventory.equippedLegArmour.attributeValues.charismaAtt + this.entityInventory.equippedFeetArmour.attributeValues.charismaAtt;
        return total;
    }

    public override int CalculateEntityLuckFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialLuck() + this.entityInventory.equippedChestArmour.CalculateMaterialLuck() + this.entityInventory.equippedHandArmour.CalculateMaterialLuck() + this.entityInventory.equippedLegArmour.CalculateMaterialLuck() + this.entityInventory.equippedFeetArmour.CalculateMaterialLuck();
        total += this.entityInventory.equippedHeadArmour.attributeValues.luckAtt + this.entityInventory.equippedChestArmour.attributeValues.luckAtt + this.entityInventory.equippedHandArmour.attributeValues.luckAtt + this.entityInventory.equippedLegArmour.attributeValues.luckAtt + this.entityInventory.equippedFeetArmour.attributeValues.luckAtt;
        return total;
    }

    public override int CalculateEntityMindFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMind() + this.entityInventory.equippedChestArmour.CalculateMaterialMind() + this.entityInventory.equippedHandArmour.CalculateMaterialMind() + this.entityInventory.equippedLegArmour.CalculateMaterialMind() + this.entityInventory.equippedFeetArmour.CalculateMaterialMind();
        total += this.entityInventory.equippedHeadArmour.attributeValues.mindAtt + this.entityInventory.equippedChestArmour.attributeValues.mindAtt + this.entityInventory.equippedHandArmour.attributeValues.mindAtt + this.entityInventory.equippedLegArmour.attributeValues.mindAtt + this.entityInventory.equippedFeetArmour.attributeValues.mindAtt;
        return total;
    }
    #endregion
}
