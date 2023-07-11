using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanelController : MonoBehaviour
{
    public GameObject playerStatsPanel;
    public GameObject playerInventoryPanel;
    public GameObject playerEquipmentPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TogglePlayerStatsPanel()
    {
        playerStatsPanel.SetActive(true);
        playerInventoryPanel.SetActive(false);
        playerEquipmentPanel.SetActive(false);
    }

    public void TogglePlayerInventoryPanel()
    {
        playerStatsPanel.SetActive(false);
        playerInventoryPanel.SetActive(true);
        playerEquipmentPanel.SetActive(false);
    }

    public void TogglePlayerEquipmentPanel()
    {
        playerStatsPanel.SetActive(false);
        playerInventoryPanel.SetActive(false);
        playerEquipmentPanel.SetActive(true);
    }

}
