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

    }

}
