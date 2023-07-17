using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyItemStatsPanel : MonoBehaviour
{
    //public GameObject equipLeftWepButton, equipRightWepButton, equipArmourButton, unequipButton;
    public Inventory enemyInventory;
    public InventoryItem itemToShow; // Item that will be shown in the panel
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public bool isItemEquipped; // Whether the item is equipped or not
    public int equippedItemIndex; // Index of the equipped item in the inventory
    public TextMeshProUGUI healthText = null;
    //public TextMeshProUGUI currentHealthText = null;
    public TextMeshProUGUI manaText = null;
    //public TextMeshProUGUI currentManaText = null;
    public TextMeshProUGUI staminaText = null;
    //public TextMeshProUGUI currentStaminaText = null;
    public TextMeshProUGUI energyText = null;
    //public TextMeshProUGUI currentEnergyText = null;
    public TextMeshProUGUI magicText = null;
    //public TextMeshProUGUI currentMagicText = null;
    public TextMeshProUGUI strengthText = null;
    public TextMeshProUGUI dexterityText = null;
    public TextMeshProUGUI constitutionText = null;
    public TextMeshProUGUI intelligenceText = null;
    public TextMeshProUGUI wisdomText = null;
    public TextMeshProUGUI focusText = null;
    public TextMeshProUGUI charismaText = null;
    public TextMeshProUGUI luckText = null;
    public TextMeshProUGUI mindText = null;

    private void Start()
    {
        InventoryItemPrefab.OnClickEnemyItem += SetItem; // When the inventory item is clicked, set the item to show
        InventoryItemPrefab.OnIsEnemyItemEquippedCheck += EquippedCheck;  // When the enemy item is clicked, check if the item is equipped
        EquippedItemPrefab.OnClickEnemyItem += SetItem; // When the equipped item is clicked, set the item to show
        EquippedItemPrefab.OnIsEnemyItemEquippedCheck += EquippedCheck; // When the enemy item is clicked, check if the item is equipped
        EquippedItemPrefab.OnSetEnemyItemIndex += GetItemIndex; // When the equipped item is clicked, set the index of the equipped item to equippedItemIndex
        this.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void SetItem(InventoryItem item)
    {
        itemToShow = item;
        nameText.text = itemToShow.itemName;
        descriptionText.text = itemToShow.itemDescription;
        // Checks if the item class is WeaponBase or ArmourBase and calls the appropriate functions
        if (itemToShow as WeaponBase == true)
        {
            healthText.text = "Health: " + ((itemToShow as WeaponBase).CalculateMaterialMaxHealth() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxHealth() + (itemToShow as WeaponBase).resourceValues.maxHealth).ToString();
            manaText.text = "Mana: " + ((itemToShow as WeaponBase).CalculateMaterialMaxMana() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxMana() + (itemToShow as WeaponBase).resourceValues.maxMana).ToString();
            staminaText.text = "Stamina: " + ((itemToShow as WeaponBase).CalculateMaterialMaxStamina() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxStamina() + (itemToShow as WeaponBase).resourceValues.maxStamina).ToString();
            energyText.text = "Energy: " + ((itemToShow as WeaponBase).CalculateMaterialMaxEnergy() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxEnergy() + (itemToShow as WeaponBase).resourceValues.maxEnergy).ToString();
            magicText.text = "Magic: " + ((itemToShow as WeaponBase).CalculateMaterialMaxMagic() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxMagic() + (itemToShow as WeaponBase).resourceValues.maxMagic).ToString();
            strengthText.text = "Strength: " + ((itemToShow as WeaponBase).CalculateMaterialStrength() + (itemToShow as WeaponBase).CalculateWeaponTypeStrength() + (itemToShow as WeaponBase).attributeValues.strengthAtt).ToString();
            dexterityText.text = "Dexterity: " + ((itemToShow as WeaponBase).CalculateMaterialDexterity() + (itemToShow as WeaponBase).CalculateWeaponTypeDexterity() + (itemToShow as WeaponBase).attributeValues.dexterityAtt).ToString();
            constitutionText.text = "Constitution: " + ((itemToShow as WeaponBase).CalculateMaterialConstitution() + (itemToShow as WeaponBase).CalculateWeaponTypeConstitution() + (itemToShow as WeaponBase).attributeValues.constitutionAtt).ToString();
            intelligenceText.text = "Intelligence: " + ((itemToShow as WeaponBase).CalculateMaterialIntelligence() + (itemToShow as WeaponBase).CalculateWeaponTypeIntelligence() + (itemToShow as WeaponBase).attributeValues.intelligenceAtt).ToString();
            wisdomText.text = "Wisdom: " + ((itemToShow as WeaponBase).CalculateMaterialWisdom() + (itemToShow as WeaponBase).CalculateWeaponTypeWisdom() + (itemToShow as WeaponBase).attributeValues.wisdomAtt).ToString();
            focusText.text = "Focus: " + ((itemToShow as WeaponBase).CalculateMaterialFocus() + (itemToShow as WeaponBase).CalculateWeaponTypeFocus() + (itemToShow as WeaponBase).attributeValues.focusAtt).ToString();
            charismaText.text = "Charisma: " + ((itemToShow as WeaponBase).CalculateMaterialCharisma() + (itemToShow as WeaponBase).CalculateWeaponTypeCharisma() + (itemToShow as WeaponBase).attributeValues.charismaAtt).ToString();
            luckText.text = "Luck: " + ((itemToShow as WeaponBase).CalculateMaterialLuck() + (itemToShow as WeaponBase).CalculateWeaponTypeLuck() + (itemToShow as WeaponBase).attributeValues.luckAtt).ToString();
            mindText.text = "Mind: " + ((itemToShow as WeaponBase).CalculateMaterialMind() + (itemToShow as WeaponBase).CalculateWeaponTypeMind() + (itemToShow as WeaponBase).attributeValues.mindAtt).ToString();
        }
        else if (itemToShow as ArmourBase == true)
        {
            healthText.text = "Health: " + ((itemToShow as ArmourBase).CalculateMaterialMaxHealth() + (itemToShow as ArmourBase).resourceValues.maxHealth).ToString();
            manaText.text = "Mana: " + ((itemToShow as ArmourBase).CalculateMaterialMaxMana() + (itemToShow as ArmourBase).resourceValues.maxMana).ToString();
            staminaText.text = "Stamina: " + ((itemToShow as ArmourBase).CalculateMaterialMaxStamina() + (itemToShow as ArmourBase).resourceValues.maxStamina).ToString();
            energyText.text = "Energy: " + ((itemToShow as ArmourBase).CalculateMaterialMaxEnergy() + (itemToShow as ArmourBase).resourceValues.maxEnergy).ToString();
            magicText.text = "Magic: " + ((itemToShow as ArmourBase).CalculateMaterialMaxEnergy() + (itemToShow as ArmourBase).resourceValues.maxMagic).ToString();
            strengthText.text = "Strength: " + ((itemToShow as ArmourBase).CalculateMaterialStrength() + (itemToShow as ArmourBase).attributeValues.strengthAtt).ToString();
            dexterityText.text = "Dexterity: " + ((itemToShow as ArmourBase).CalculateMaterialDexterity() + (itemToShow as ArmourBase).attributeValues.dexterityAtt).ToString();
            constitutionText.text = "Constitution: " + ((itemToShow as ArmourBase).CalculateMaterialConstitution() + (itemToShow as ArmourBase).attributeValues.constitutionAtt).ToString();
            intelligenceText.text = "Intelligence: " + ((itemToShow as ArmourBase).CalculateMaterialIntelligence() + (itemToShow as ArmourBase).attributeValues.intelligenceAtt).ToString();
            wisdomText.text = "Wisdom: " + ((itemToShow as ArmourBase).CalculateMaterialWisdom() + (itemToShow as ArmourBase).attributeValues.wisdomAtt).ToString();
            focusText.text = "Focus: " + ((itemToShow as ArmourBase).CalculateMaterialFocus() + (itemToShow as ArmourBase).attributeValues.focusAtt).ToString();
            charismaText.text = "Charisma: " + ((itemToShow as ArmourBase).CalculateMaterialCharisma() + (itemToShow as ArmourBase).attributeValues.charismaAtt).ToString();
            luckText.text = "Luck: " + ((itemToShow as ArmourBase).CalculateMaterialLuck() + (itemToShow as ArmourBase).attributeValues.luckAtt).ToString();
            mindText.text = "Mind: " + ((itemToShow as ArmourBase).CalculateMaterialMind() + (itemToShow as ArmourBase).attributeValues.mindAtt).ToString();
        }
    }
    public void GetItemIndex(int index)
    {
        equippedItemIndex = index;
    }
    public void ClosePanel()
    {
        this.gameObject.SetActive(false);
    }
    private void EquipArmour(InventoryItem item)
    {
        enemyInventory.SetArmour(item as ArmourBase);
        enemyInventory.RemoveItem(item);
    }
    private void EquipLeftWeapon(InventoryItem item)
    {
        enemyInventory.SetLeftWeapon(item as WeaponBase);
        enemyInventory.RemoveItem(item);
    }
    private void EquipRightWeapon(InventoryItem item)
    {
        enemyInventory.SetRightWeapon(item as WeaponBase);
        enemyInventory.RemoveItem(item);
    }
    private void UnequipItem(InventoryItem item)
    {
        enemyInventory.AddItem(item);
        enemyInventory.UnequipItem(equippedItemIndex);
    }
    public void EquipArmourButton()
    {
        EquipArmour(itemToShow);
        ClosePanel();
    }
    public void EquipLeftWeaponButton()
    {
        EquipLeftWeapon(itemToShow);
        ClosePanel();
    }
    public void EquipRightWeaponButton()
    {
        EquipRightWeapon(itemToShow);
        ClosePanel();
    }
    public void EquippedCheck(bool isEquipped)
    {
        isItemEquipped = isEquipped;
    }
    public void UnequipButton()
    {
        UnequipItem(itemToShow);
        ClosePanel();
    }
}
