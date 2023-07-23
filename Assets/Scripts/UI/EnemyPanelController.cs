using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPanelController : MonoBehaviour
{
    public Enemy enemy;
    public GameObject enemyStatsPanel;
    public GameObject enemyInventoryPanel;
    public GameObject enemyEquipmentPanel;
    public GameObject enemyItemStatsPanel;

    // Start is called before the first frame update
    void Start()
    {
        InventoryItemPrefab.OnShowEnemyItemPanel += ToggleEnemyItemStatsPanel;
        EquippedItemPrefab.OnShowEnemyItemPanel += ToggleEnemyItemStatsPanel;
    }

    // Update is called once per frame
    void Update() { }

    public void ToggleEnemyStatsPanel()
    {
        enemyStatsPanel.SetActive(true);
        enemyInventoryPanel.SetActive(false);
        enemyEquipmentPanel.SetActive(false);
    }

    public void ToggleEnemyInventoryPanel()
    {
        enemyStatsPanel.SetActive(false);
        enemyInventoryPanel.SetActive(true);
        enemyEquipmentPanel.SetActive(false);
    }

    public void ToggleEnemyEquipmentPanel()
    {
        enemyStatsPanel.SetActive(false);
        enemyInventoryPanel.SetActive(false);
        enemyEquipmentPanel.SetActive(true);
    }
    public void ToggleEnemyItemStatsPanel()
    {
        enemyItemStatsPanel.SetActive(true);
    }
}
