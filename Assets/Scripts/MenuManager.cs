using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MenuManager : MonoBehaviour
{
    public Player player = null;
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

    // Start is called before the first frame update
    void Start()
    {
        //text.text = weapon.totalMaxHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        healthText.text = player.currentHealth.ToString() + " / " + player.maxHealth.ToString();
        manaText.text = player.currentMana.ToString() + " / " + player.maxMana.ToString();
        staminaText.text = player.currentStamina.ToString() + " / " + player.maxStamina.ToString();
        energyText.text = player.currentEnergy.ToString() + " / " + player.maxEnergy.ToString();
        magicText.text = player.currentMagic.ToString() + " / " + player.maxMagic.ToString();

        strengthText.text = player.strength.ToString();
        dexterityText.text = player.dexterity.ToString();
        constitutionText.text = player.constitution.ToString();
        intelligenceText.text = player.intelligence.ToString();
        wisdomText.text = player.wisdom.ToString();
        focusText.text = player.focus.ToString();
        charismaText.text = player.charisma.ToString();
        luckText.text = player.luck.ToString();
        mindText.text = player.mind.ToString();
    }
}
