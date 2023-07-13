using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanelController : MonoBehaviour
{
    public GameObject playerStatsPanel;
    public GameObject playerInventoryPanel;
    public GameObject playerEquipmentPanel;
    public GameObject playerItemStatsPanel;

    // Start is called before the first frame update
    void Start()
    {
        InventoryItemPrefab.OnShowItemPanel += TogglePlayerItemStatsPanel;
        EquippedItemPrefab.OnShowItemPanel += TogglePlayerItemStatsPanel;
    }

    // Update is called once per frame
    void Update() { }

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
    public void TogglePlayerItemStatsPanel()
    {
        playerItemStatsPanel.SetActive(true);
    }
}
