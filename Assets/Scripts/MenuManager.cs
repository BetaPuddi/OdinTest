using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI text = null;
    public Player player = null;

    // Start is called before the first frame update
    void Start()
    {
        //text.text = weapon.totalMaxHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        text.text = player.maxHealth.ToString();
    }
}
