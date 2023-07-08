using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{


    // Start is called before the first frame update
    void Start()
    {
        this.entityInventory = this.GetComponent<Inventory>();

        this.currentHealth = this.maxHealth;
        this.currentMana = this.maxMana;
        this.currentStamina = this.maxStamina;
        this.currentEnergy = this.maxEnergy;
        this.currentMagic = this.maxMagic;
    }

    // Update is called once per frame
    void Update()
    {
        this.maxHealth = CalculatePlayerMaxHealthFromWeapons() + CalculatePlayerMaxHealthFromArmour();
        this.maxMana = CalculatePlayerMaxManaFromWeapons() + CalculatePlayerMaxManaFromArmour();
        this.maxStamina = CalculatePlayerMaxStaminaFromWeapons() + CalculatePlayerMaxStaminaFromArmour();
        this.maxEnergy = CalculatePlayerMaxEnergyFromWeapons() + CalculatePlayerMaxEnergyFromArmour();
        this.maxMagic = CalculatePlayerMaxMagicFromWeapons() + CalculatePlayerMaxMagicFromArmour();
    }

    // Resource Calculations
    public int CalculatePlayerMaxHealthFromWeapons()
    {
        int total = 0;

        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxHealth() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxHealth();

        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxHealth() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxHealth();

        return total;
    }

    public int CalculatePlayerMaxManaFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxMana() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxMana();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxMana() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxMana();
        return total;
    }

    public int CalculatePlayerMaxStaminaFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxStamina() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxStamina();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxStamina() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxStamina();
        return total;
    }

    public int CalculatePlayerMaxEnergyFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxEnergy() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxEnergy();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxEnergy() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxEnergy();
        return total;
    }

    public int CalculatePlayerMaxMagicFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialMaxMagic() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeMaxMagic();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialMaxMagic() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeMaxMagic();
        return total;
    }

    public int CalculatePlayerMaxHealthFromArmour()
    {
        int total = 0;

        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxHealth() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxHealth() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxHealth() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxHealth() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxHealth();

        return total;
    }

    public int CalculatePlayerMaxManaFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxMana() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxMana() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxMana() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxMana() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxMana();
        return total;
    }

    public int CalculatePlayerMaxStaminaFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxStamina() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxStamina() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxStamina() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxStamina() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxStamina();
        return total;
    }

    public int CalculatePlayerMaxEnergyFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxEnergy() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxEnergy() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxEnergy() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxEnergy() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxEnergy();
        return total;
    }

    public int CalculatePlayerMaxMagicFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMaxMagic() + this.entityInventory.equippedChestArmour.CalculateMaterialMaxMagic() + this.entityInventory.equippedHandArmour.CalculateMaterialMaxMagic() + this.entityInventory.equippedLegArmour.CalculateMaterialMaxMagic() + this.entityInventory.equippedFeetArmour.CalculateMaterialMaxMagic();
        return total;
    }

    // Attribute Calculations
    public int CalculatePlayerStrengthFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialStrength() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeStrength();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialStrength() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeStrength();
        return total;
    }

    public int CalculatePlayerDexterityFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialDexterity() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeDexterity();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialDexterity() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeDexterity();
        return total;
    }

    public int CalculatePlayerConstitutionFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialConstitution() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeConstitution();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialConstitution() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeConstitution();
        return total;
    }

    public int CalculatePlayerIntelligenceFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialIntelligence() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeIntelligence();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialIntelligence() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeIntelligence();
        return total;
    }

    public int CalculatePlayerWisdomFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialWisdom() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeWisdom();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialWisdom() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeWisdom();
        return total;
    }

    public int CalculatePlayerFocusFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialFocus() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeFocus();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialFocus() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeFocus();
        return total;
    }

    public int CalculatePlayerCharismaFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialCharisma() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeCharisma();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialCharisma() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeCharisma();
        return total;
    }

    public int CalculatePlayerLuckFromWeapons()
    {
        int total = 0;
        total = this.entityInventory.equippedWeaponRight.CalculateMaterialLuck() + this.entityInventory.equippedWeaponRight.CalculateWeaponTypeLuck();
        total += this.entityInventory.equippedWeaponLeft.CalculateMaterialLuck() + this.entityInventory.equippedWeaponLeft.CalculateWeaponTypeLuck();
        return total;
    }

    public int CalculatePlayerStrengthFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialStrength() + this.entityInventory.equippedChestArmour.CalculateMaterialStrength() + this.entityInventory.equippedHandArmour.CalculateMaterialStrength() + this.entityInventory.equippedLegArmour.CalculateMaterialStrength() + this.entityInventory.equippedFeetArmour.CalculateMaterialStrength();
        return total;
    }

    public int CalculatePlayerDexterityFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialDexterity() + this.entityInventory.equippedChestArmour.CalculateMaterialDexterity() + this.entityInventory.equippedHandArmour.CalculateMaterialDexterity() + this.entityInventory.equippedLegArmour.CalculateMaterialDexterity() + this.entityInventory.equippedFeetArmour.CalculateMaterialDexterity();
        return total;
    }

    public int CalculatePlayerConstitutionFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialConstitution() + this.entityInventory.equippedChestArmour.CalculateMaterialConstitution() + this.entityInventory.equippedHandArmour.CalculateMaterialConstitution() + this.entityInventory.equippedLegArmour.CalculateMaterialConstitution() + this.entityInventory.equippedFeetArmour.CalculateMaterialConstitution();
        return total;
    }

    public int CalculatePlayerIntelligenceFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialIntelligence() + this.entityInventory.equippedChestArmour.CalculateMaterialIntelligence() + this.entityInventory.equippedHandArmour.CalculateMaterialIntelligence() + this.entityInventory.equippedLegArmour.CalculateMaterialIntelligence() + this.entityInventory.equippedFeetArmour.CalculateMaterialIntelligence();
        return total;
    }

    public int CalculatePlayerWisdomFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialWisdom() + this.entityInventory.equippedChestArmour.CalculateMaterialWisdom() + this.entityInventory.equippedHandArmour.CalculateMaterialWisdom() + this.entityInventory.equippedLegArmour.CalculateMaterialWisdom() + this.entityInventory.equippedFeetArmour.CalculateMaterialWisdom();
        return total;
    }

    public int CalculatePlayerFocusFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialFocus() + this.entityInventory.equippedChestArmour.CalculateMaterialFocus() + this.entityInventory.equippedHandArmour.CalculateMaterialFocus() + this.entityInventory.equippedLegArmour.CalculateMaterialFocus() + this.entityInventory.equippedFeetArmour.CalculateMaterialFocus();
        return total;
    }

    public int CalculatePlayerCharismaFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialCharisma() + this.entityInventory.equippedChestArmour.CalculateMaterialCharisma() + this.entityInventory.equippedHandArmour.CalculateMaterialCharisma() + this.entityInventory.equippedLegArmour.CalculateMaterialCharisma() + this.entityInventory.equippedFeetArmour.CalculateMaterialCharisma();
        return total;
    }

    public int CalculatePlayerLuckFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialLuck() + this.entityInventory.equippedChestArmour.CalculateMaterialLuck() + this.entityInventory.equippedHandArmour.CalculateMaterialLuck() + this.entityInventory.equippedLegArmour.CalculateMaterialLuck() + this.entityInventory.equippedFeetArmour.CalculateMaterialLuck();
        return total;
    }

    public int CalculatePlayerMindFromArmour()
    {
        int total = 0;
        total = this.entityInventory.equippedHeadArmour.CalculateMaterialMind() + this.entityInventory.equippedChestArmour.CalculateMaterialMind() + this.entityInventory.equippedHandArmour.CalculateMaterialMind() + this.entityInventory.equippedLegArmour.CalculateMaterialMind() + this.entityInventory.equippedFeetArmour.CalculateMaterialMind();
        return total;
    }
}
