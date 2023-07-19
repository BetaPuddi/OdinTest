using System;
using UnityEngine;

public class Enemy : Entity
{
    public EnemyInventory inventory;
    // Inherits stats and name from Entity
    void Start()
    {
        //this.inventory = this.GetComponent<EInventory>(); // Get the inventory component attached to the game object

        // TODO: Replace current health initialization
        this.currentHealth = this.maxHealth;
        this.currentMana = this.maxMana;
        this.currentStamina = this.maxStamina;
        this.currentEnergy = this.maxEnergy;
        this.currentMagic = this.maxMagic;
    }
    private void Update()
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
    #region Resource Calculations
    public override int CalculateEntityMaxHealthFromWeapons()
    {
        int total = 0;

        total = this.inventory.equippedWeaponRight.CalculateMaterialMaxHealth() + this.inventory.equippedWeaponRight.CalculateWeaponTypeMaxHealth() + this.inventory.equippedWeaponRight.resourceValues.maxHealth;

        total += this.inventory.equippedWeaponLeft.CalculateMaterialMaxHealth() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeMaxHealth() + this.inventory.equippedWeaponLeft.resourceValues.maxHealth;

        return total;
    }

    public override int CalculateEntityMaxManaFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialMaxMana() + this.inventory.equippedWeaponRight.CalculateWeaponTypeMaxMana() + this.inventory.equippedWeaponRight.resourceValues.maxMana;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialMaxMana() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeMaxMana() + this.inventory.equippedWeaponLeft.resourceValues.maxMana;
        return total;
    }

    public override int CalculateEntityMaxStaminaFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialMaxStamina() + this.inventory.equippedWeaponRight.CalculateWeaponTypeMaxStamina() + this.inventory.equippedWeaponRight.resourceValues.maxStamina;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialMaxStamina() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeMaxStamina() + this.inventory.equippedWeaponLeft.resourceValues.maxStamina;
        return total;
    }

    public override int CalculateEntityMaxEnergyFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialMaxEnergy() + this.inventory.equippedWeaponRight.CalculateWeaponTypeMaxEnergy() + this.inventory.equippedWeaponRight.resourceValues.maxEnergy;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialMaxEnergy() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeMaxEnergy() + this.inventory.equippedWeaponLeft.resourceValues.maxEnergy;
        return total;
    }

    public override int CalculateEntityMaxMagicFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialMaxMagic() + this.inventory.equippedWeaponRight.CalculateWeaponTypeMaxMagic() + this.inventory.equippedWeaponRight.resourceValues.maxMagic;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialMaxMagic() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeMaxMagic() + this.inventory.equippedWeaponLeft.resourceValues.maxMagic;
        return total;
    }

    public override int CalculateEntityMaxHealthFromArmour()
    {
        int total = 0;

        total = this.inventory.equippedHeadArmour.CalculateMaterialMaxHealth() + this.inventory.equippedChestArmour.CalculateMaterialMaxHealth() + this.inventory.equippedHandArmour.CalculateMaterialMaxHealth() + this.inventory.equippedLegArmour.CalculateMaterialMaxHealth() + this.inventory.equippedFeetArmour.CalculateMaterialMaxHealth();
        total += this.inventory.equippedHeadArmour.resourceValues.maxHealth + this.inventory.equippedChestArmour.resourceValues.maxHealth + this.inventory.equippedHandArmour.resourceValues.maxHealth + this.inventory.equippedLegArmour.resourceValues.maxHealth + this.inventory.equippedFeetArmour.resourceValues.maxHealth;

        return total;
    }

    public override int CalculateEntityMaxManaFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialMaxMana() + this.inventory.equippedChestArmour.CalculateMaterialMaxMana() + this.inventory.equippedHandArmour.CalculateMaterialMaxMana() + this.inventory.equippedLegArmour.CalculateMaterialMaxMana() + this.inventory.equippedFeetArmour.CalculateMaterialMaxMana();
        total += this.inventory.equippedHeadArmour.resourceValues.maxMana + this.inventory.equippedChestArmour.resourceValues.maxMana + this.inventory.equippedHandArmour.resourceValues.maxMana + this.inventory.equippedLegArmour.resourceValues.maxMana + this.inventory.equippedFeetArmour.resourceValues.maxMana;
        return total;
    }

    public override int CalculateEntityMaxStaminaFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialMaxStamina() + this.inventory.equippedChestArmour.CalculateMaterialMaxStamina() + this.inventory.equippedHandArmour.CalculateMaterialMaxStamina() + this.inventory.equippedLegArmour.CalculateMaterialMaxStamina() + this.inventory.equippedFeetArmour.CalculateMaterialMaxStamina();
        total += this.inventory.equippedHeadArmour.resourceValues.maxStamina + this.inventory.equippedChestArmour.resourceValues.maxStamina + this.inventory.equippedHandArmour.resourceValues.maxStamina + this.inventory.equippedLegArmour.resourceValues.maxStamina + this.inventory.equippedFeetArmour.resourceValues.maxStamina;
        return total;
    }

    public override int CalculateEntityMaxEnergyFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialMaxEnergy() + this.inventory.equippedChestArmour.CalculateMaterialMaxEnergy() + this.inventory.equippedHandArmour.CalculateMaterialMaxEnergy() + this.inventory.equippedLegArmour.CalculateMaterialMaxEnergy() + this.inventory.equippedFeetArmour.CalculateMaterialMaxEnergy();
        total += this.inventory.equippedHeadArmour.resourceValues.maxEnergy + this.inventory.equippedChestArmour.resourceValues.maxEnergy + this.inventory.equippedHandArmour.resourceValues.maxEnergy + this.inventory.equippedLegArmour.resourceValues.maxEnergy + this.inventory.equippedFeetArmour.resourceValues.maxEnergy;
        return total;
    }

    public override int CalculateEntityMaxMagicFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialMaxMagic() + this.inventory.equippedChestArmour.CalculateMaterialMaxMagic() + this.inventory.equippedHandArmour.CalculateMaterialMaxMagic() + this.inventory.equippedLegArmour.CalculateMaterialMaxMagic() + this.inventory.equippedFeetArmour.CalculateMaterialMaxMagic();
        total += this.inventory.equippedHeadArmour.resourceValues.maxMagic + this.inventory.equippedChestArmour.resourceValues.maxMagic + this.inventory.equippedHandArmour.resourceValues.maxMagic + this.inventory.equippedLegArmour.resourceValues.maxMagic + this.inventory.equippedFeetArmour.resourceValues.maxMagic;
        return total;
    }
    #endregion

    // Attribute Calculations
    #region Attribute Calculations
    public override int CalculateEntityStrengthFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialStrength() + this.inventory.equippedWeaponRight.CalculateWeaponTypeStrength() + this.inventory.equippedWeaponRight.attributeValues.strengthAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialStrength() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeStrength() + this.inventory.equippedWeaponLeft.attributeValues.strengthAtt;
        return total;
    }

    public override int CalculateEntityDexterityFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialDexterity() + this.inventory.equippedWeaponRight.CalculateWeaponTypeDexterity() + this.inventory.equippedWeaponRight.attributeValues.dexterityAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialDexterity() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeDexterity() + this.inventory.equippedWeaponLeft.attributeValues.dexterityAtt;
        return total;
    }

    public override int CalculateEntityConstitutionFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialConstitution() + this.inventory.equippedWeaponRight.CalculateWeaponTypeConstitution() + this.inventory.equippedWeaponRight.attributeValues.constitutionAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialConstitution() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeConstitution() + this.inventory.equippedWeaponLeft.attributeValues.constitutionAtt;
        return total;
    }

    public override int CalculateEntityIntelligenceFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialIntelligence() + this.inventory.equippedWeaponRight.CalculateWeaponTypeIntelligence() + this.inventory.equippedWeaponRight.attributeValues.intelligenceAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialIntelligence() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeIntelligence() + this.inventory.equippedWeaponLeft.attributeValues.intelligenceAtt;
        return total;
    }

    public override int CalculateEntityWisdomFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialWisdom() + this.inventory.equippedWeaponRight.CalculateWeaponTypeWisdom() + this.inventory.equippedWeaponRight.attributeValues.wisdomAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialWisdom() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeWisdom() + this.inventory.equippedWeaponLeft.attributeValues.wisdomAtt;
        return total;
    }

    public override int CalculateEntityFocusFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialFocus() + this.inventory.equippedWeaponRight.CalculateWeaponTypeFocus() + this.inventory.equippedWeaponRight.attributeValues.focusAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialFocus() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeFocus() + this.inventory.equippedWeaponLeft.attributeValues.focusAtt;
        return total;
    }

    public override int CalculateEntityCharismaFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialCharisma() + this.inventory.equippedWeaponRight.CalculateWeaponTypeCharisma() + this.inventory.equippedWeaponRight.attributeValues.charismaAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialCharisma() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeCharisma() + this.inventory.equippedWeaponLeft.attributeValues.charismaAtt;
        return total;
    }

    public override int CalculateEntityLuckFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialLuck() + this.inventory.equippedWeaponRight.CalculateWeaponTypeLuck() + this.inventory.equippedWeaponRight.attributeValues.luckAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialLuck() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeLuck() + this.inventory.equippedWeaponLeft.attributeValues.luckAtt;
        return total;
    }

    public override int CalculateEntityMindFromWeapons()
    {
        int total = 0;
        total = this.inventory.equippedWeaponRight.CalculateMaterialMind() + this.inventory.equippedWeaponRight.CalculateWeaponTypeMind() + this.inventory.equippedWeaponRight.attributeValues.mindAtt;
        total += this.inventory.equippedWeaponLeft.CalculateMaterialMind() + this.inventory.equippedWeaponLeft.CalculateWeaponTypeMind() + this.inventory.equippedWeaponLeft.attributeValues.mindAtt;
        return total;
    }

    public override int CalculateEntityStrengthFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialStrength() + this.inventory.equippedChestArmour.CalculateMaterialStrength() + this.inventory.equippedHandArmour.CalculateMaterialStrength() + this.inventory.equippedLegArmour.CalculateMaterialStrength() + this.inventory.equippedFeetArmour.CalculateMaterialStrength();
        total += this.inventory.equippedHeadArmour.attributeValues.strengthAtt + this.inventory.equippedChestArmour.attributeValues.strengthAtt + this.inventory.equippedHandArmour.attributeValues.strengthAtt + this.inventory.equippedLegArmour.attributeValues.strengthAtt + this.inventory.equippedFeetArmour.attributeValues.strengthAtt;
        return total;
    }

    public override int CalculateEntityDexterityFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialDexterity() + this.inventory.equippedChestArmour.CalculateMaterialDexterity() + this.inventory.equippedHandArmour.CalculateMaterialDexterity() + this.inventory.equippedLegArmour.CalculateMaterialDexterity() + this.inventory.equippedFeetArmour.CalculateMaterialDexterity();
        total += this.inventory.equippedHeadArmour.attributeValues.dexterityAtt + this.inventory.equippedChestArmour.attributeValues.dexterityAtt + this.inventory.equippedHandArmour.attributeValues.dexterityAtt + this.inventory.equippedLegArmour.attributeValues.dexterityAtt + this.inventory.equippedFeetArmour.attributeValues.dexterityAtt;
        return total;
    }

    public override int CalculateEntityConstitutionFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialConstitution() + this.inventory.equippedChestArmour.CalculateMaterialConstitution() + this.inventory.equippedHandArmour.CalculateMaterialConstitution() + this.inventory.equippedLegArmour.CalculateMaterialConstitution() + this.inventory.equippedFeetArmour.CalculateMaterialConstitution();
        total += this.inventory.equippedHeadArmour.attributeValues.constitutionAtt + this.inventory.equippedChestArmour.attributeValues.constitutionAtt + this.inventory.equippedHandArmour.attributeValues.constitutionAtt + this.inventory.equippedLegArmour.attributeValues.constitutionAtt + this.inventory.equippedFeetArmour.attributeValues.constitutionAtt;
        return total;
    }

    public override int CalculateEntityIntelligenceFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialIntelligence() + this.inventory.equippedChestArmour.CalculateMaterialIntelligence() + this.inventory.equippedHandArmour.CalculateMaterialIntelligence() + this.inventory.equippedLegArmour.CalculateMaterialIntelligence() + this.inventory.equippedFeetArmour.CalculateMaterialIntelligence();
        total += this.inventory.equippedHeadArmour.attributeValues.intelligenceAtt + this.inventory.equippedChestArmour.attributeValues.intelligenceAtt + this.inventory.equippedHandArmour.attributeValues.intelligenceAtt + this.inventory.equippedLegArmour.attributeValues.intelligenceAtt + this.inventory.equippedFeetArmour.attributeValues.intelligenceAtt;
        return total;
    }

    public override int CalculateEntityWisdomFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialWisdom() + this.inventory.equippedChestArmour.CalculateMaterialWisdom() + this.inventory.equippedHandArmour.CalculateMaterialWisdom() + this.inventory.equippedLegArmour.CalculateMaterialWisdom() + this.inventory.equippedFeetArmour.CalculateMaterialWisdom();
        total += this.inventory.equippedHeadArmour.attributeValues.wisdomAtt + this.inventory.equippedChestArmour.attributeValues.wisdomAtt + this.inventory.equippedHandArmour.attributeValues.wisdomAtt + this.inventory.equippedLegArmour.attributeValues.wisdomAtt + this.inventory.equippedFeetArmour.attributeValues.wisdomAtt;
        return total;
    }

    public override int CalculateEntityFocusFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialFocus() + this.inventory.equippedChestArmour.CalculateMaterialFocus() + this.inventory.equippedHandArmour.CalculateMaterialFocus() + this.inventory.equippedLegArmour.CalculateMaterialFocus() + this.inventory.equippedFeetArmour.CalculateMaterialFocus();
        total += this.inventory.equippedHeadArmour.attributeValues.focusAtt + this.inventory.equippedChestArmour.attributeValues.focusAtt + this.inventory.equippedHandArmour.attributeValues.focusAtt + this.inventory.equippedLegArmour.attributeValues.focusAtt + this.inventory.equippedFeetArmour.attributeValues.focusAtt;
        return total;
    }

    public override int CalculateEntityCharismaFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialCharisma() + this.inventory.equippedChestArmour.CalculateMaterialCharisma() + this.inventory.equippedHandArmour.CalculateMaterialCharisma() + this.inventory.equippedLegArmour.CalculateMaterialCharisma() + this.inventory.equippedFeetArmour.CalculateMaterialCharisma();
        total += this.inventory.equippedHeadArmour.attributeValues.charismaAtt + this.inventory.equippedChestArmour.attributeValues.charismaAtt + this.inventory.equippedHandArmour.attributeValues.charismaAtt + this.inventory.equippedLegArmour.attributeValues.charismaAtt + this.inventory.equippedFeetArmour.attributeValues.charismaAtt;
        return total;
    }

    public override int CalculateEntityLuckFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialLuck() + this.inventory.equippedChestArmour.CalculateMaterialLuck() + this.inventory.equippedHandArmour.CalculateMaterialLuck() + this.inventory.equippedLegArmour.CalculateMaterialLuck() + this.inventory.equippedFeetArmour.CalculateMaterialLuck();
        total += this.inventory.equippedHeadArmour.attributeValues.luckAtt + this.inventory.equippedChestArmour.attributeValues.luckAtt + this.inventory.equippedHandArmour.attributeValues.luckAtt + this.inventory.equippedLegArmour.attributeValues.luckAtt + this.inventory.equippedFeetArmour.attributeValues.luckAtt;
        return total;
    }

    public override int CalculateEntityMindFromArmour()
    {
        int total = 0;
        total = this.inventory.equippedHeadArmour.CalculateMaterialMind() + this.inventory.equippedChestArmour.CalculateMaterialMind() + this.inventory.equippedHandArmour.CalculateMaterialMind() + this.inventory.equippedLegArmour.CalculateMaterialMind() + this.inventory.equippedFeetArmour.CalculateMaterialMind();
        total += this.inventory.equippedHeadArmour.attributeValues.mindAtt + this.inventory.equippedChestArmour.attributeValues.mindAtt + this.inventory.equippedHandArmour.attributeValues.mindAtt + this.inventory.equippedLegArmour.attributeValues.mindAtt + this.inventory.equippedFeetArmour.attributeValues.mindAtt;
        return total;
    }
    #endregion
}