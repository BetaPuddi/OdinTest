using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyStatsPanel : MonoBehaviour
{
    public Enemy enemy = null;
    public TextMeshProUGUI nameText = null;
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
        healthText.text = enemy.currentHealth.ToString() + " / " + enemy.maxHealth.ToString();
        manaText.text = enemy.currentMana.ToString() + " / " + enemy.maxMana.ToString();
        staminaText.text = enemy.currentStamina.ToString() + " / " + enemy.maxStamina.ToString();
        energyText.text = enemy.currentEnergy.ToString() + " / " + enemy.maxEnergy.ToString();
        magicText.text = enemy.currentMagic.ToString() + " / " + enemy.maxMagic.ToString();

        strengthText.text = enemy.strength.ToString();
        dexterityText.text = enemy.dexterity.ToString();
        constitutionText.text = enemy.constitution.ToString();
        intelligenceText.text = enemy.intelligence.ToString();
        wisdomText.text = enemy.wisdom.ToString();
        focusText.text = enemy.focus.ToString();
        charismaText.text = enemy.charisma.ToString();
        luckText.text = enemy.luck.ToString();
        mindText.text = enemy.mind.ToString();
        nameText.text = enemy.entityName;
    }
}
