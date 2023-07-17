using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyItemStatsPanel : MonoBehaviour
{
    //public GameObject equipLeftWepButton, equipRightWepButton, equipArmourButton, unequipButton;
    public Inventory enemyInventory;
    public InventoryItem itemToShow;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public bool isItemEquipped;
    public int equippedItemIndex;
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
        InventoryItemPrefab.OnClickItem += SetItem;
        InventoryItemPrefab.OnIsEquippedCheck += EquippedCheck;
        EquippedItemPrefab.OnClickItem += SetItem;
        EquippedItemPrefab.OnIsEquippedCheck += EquippedCheck;
        EquippedItemPrefab.OnSetItemIndex += GetItemIndex;
        this.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
    private void Update()
    {
        /*if (isItemEquipped == true && itemToShow.itemName != "Empty")
        {
            unequipButton.SetActive(true);
            equipLeftWepButton.SetActive(false);
            equipRightWepButton.SetActive(false);
            equipArmourButton.SetActive(false);
        }
        else if (isItemEquipped == true && itemToShow.itemName == "Empty")
        {
            unequipButton.SetActive(false);
            equipLeftWepButton.SetActive(false);
            equipRightWepButton.SetActive(false);
            equipArmourButton.SetActive(false);
        }
        else if (itemToShow as ArmourBase == true)
        {
            equipArmourButton.SetActive(true);
            equipLeftWepButton.SetActive(false);
            equipRightWepButton.SetActive(false);
            unequipButton.SetActive(false);
        }
        else if (itemToShow as WeaponBase == true)
        {
            equipArmourButton.SetActive(false);
            equipLeftWepButton.SetActive(true);
            equipRightWepButton.SetActive(true);
            unequipButton.SetActive(false);
        }*/
    }
    public void SetItem(InventoryItem item)
    {
        itemToShow = item;
        nameText.text = itemToShow.itemName;
        descriptionText.text = itemToShow.itemDescription;
        if (itemToShow as WeaponBase == true)
        {
            healthText.text = "Health: " + ((itemToShow as WeaponBase).CalculateMaterialMaxHealth() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxHealth()).ToString();
            manaText.text = "Mana: " + ((itemToShow as WeaponBase).CalculateMaterialMaxMana() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxMana()).ToString();
            staminaText.text = "Stamina: " + ((itemToShow as WeaponBase).CalculateMaterialMaxStamina() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxStamina()).ToString();
            energyText.text = "Energy: " + ((itemToShow as WeaponBase).CalculateMaterialMaxEnergy() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxEnergy()).ToString();
            magicText.text = "Magic: " + ((itemToShow as WeaponBase).CalculateMaterialMaxEnergy() + (itemToShow as WeaponBase).CalculateWeaponTypeMaxEnergy()).ToString();
            strengthText.text = "Strength: " + ((itemToShow as WeaponBase).CalculateMaterialStrength() + (itemToShow as WeaponBase).CalculateWeaponTypeStrength()).ToString();
            dexterityText.text = "Dexterity: " + ((itemToShow as WeaponBase).CalculateMaterialDexterity() + (itemToShow as WeaponBase).CalculateWeaponTypeDexterity()).ToString();
            constitutionText.text = "Constitution: " + ((itemToShow as WeaponBase).CalculateMaterialConstitution() + (itemToShow as WeaponBase).CalculateWeaponTypeConstitution()).ToString();
            intelligenceText.text = "Intelligence: " + ((itemToShow as WeaponBase).CalculateMaterialIntelligence() + (itemToShow as WeaponBase).CalculateWeaponTypeIntelligence()).ToString();
            wisdomText.text = "Wisdom: " + ((itemToShow as WeaponBase).CalculateMaterialWisdom() + (itemToShow as WeaponBase).CalculateWeaponTypeWisdom()).ToString();
            focusText.text = "Focus: " + ((itemToShow as WeaponBase).CalculateMaterialFocus() + (itemToShow as WeaponBase).CalculateWeaponTypeFocus()).ToString();
            charismaText.text = "Charisma: " + ((itemToShow as WeaponBase).CalculateMaterialCharisma() + (itemToShow as WeaponBase).CalculateWeaponTypeCharisma()).ToString();
            luckText.text = "Luck: " + ((itemToShow as WeaponBase).CalculateMaterialLuck() + (itemToShow as WeaponBase).CalculateWeaponTypeLuck()).ToString();
            mindText.text = "Mind: " + ((itemToShow as WeaponBase).CalculateMaterialMind() + (itemToShow as WeaponBase).CalculateWeaponTypeMind()).ToString();
        }
        else if (itemToShow as ArmourBase == true)
        {
            healthText.text = "Health: " + (itemToShow as ArmourBase).CalculateMaterialMaxHealth().ToString();
            manaText.text = "Mana: " + (itemToShow as ArmourBase).CalculateMaterialMaxMana().ToString();
            staminaText.text = "Stamina: " + (itemToShow as ArmourBase).CalculateMaterialMaxStamina().ToString();
            energyText.text = "Energy: " + (itemToShow as ArmourBase).CalculateMaterialMaxEnergy().ToString();
            magicText.text = "Magic: " + (itemToShow as ArmourBase).CalculateMaterialMaxEnergy().ToString();
            strengthText.text = "Strength: " + (itemToShow as ArmourBase).CalculateMaterialStrength().ToString();
            dexterityText.text = "Dexterity: " + (itemToShow as ArmourBase).CalculateMaterialDexterity().ToString();
            constitutionText.text = "Constitution: " + (itemToShow as ArmourBase).CalculateMaterialConstitution().ToString();
            intelligenceText.text = "Intelligence: " + (itemToShow as ArmourBase).CalculateMaterialIntelligence().ToString();
            wisdomText.text = "Wisdom: " + (itemToShow as ArmourBase).CalculateMaterialWisdom().ToString();
            focusText.text = "Focus: " + (itemToShow as ArmourBase).CalculateMaterialFocus().ToString();
            charismaText.text = "Charisma: " + (itemToShow as ArmourBase).CalculateMaterialCharisma().ToString();
            luckText.text = "Luck: " + (itemToShow as ArmourBase).CalculateMaterialLuck().ToString();
            mindText.text = "Mind: " + (itemToShow as ArmourBase).CalculateMaterialMind().ToString();
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
