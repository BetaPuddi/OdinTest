using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI maxHealthText = null;
    public TextMeshProUGUI currentHealthText = null;
    public TextMeshProUGUI maxManaText = null;
    public TextMeshProUGUI currentManaText = null;
    public TextMeshProUGUI maxStaminaText = null;
    public TextMeshProUGUI currentStaminaText = null;
    public TextMeshProUGUI maxEnergyText = null;
    public TextMeshProUGUI currentEnergyText = null;
    public TextMeshProUGUI maxMagicText = null;
    public TextMeshProUGUI currentMagicText = null;
    public Player player = null;

    // Start is called before the first frame update
    void Start()
    {
        //text.text = weapon.totalMaxHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        maxHealthText.text = player.maxHealth.ToString();
    }
}
