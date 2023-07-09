using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanelController : MonoBehaviour
{
    public GameObject playerAttributesPanel;
    public GameObject playerResourcesPanel;
    public GameObject playerInventoryPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TogglePlayerAttributePanel()
    {
        playerAttributesPanel.SetActive(true);
        playerResourcesPanel.SetActive(false);
        playerInventoryPanel.SetActive(false);
    }

    public void TogglePlayerResourcePanel()
    {
        playerAttributesPanel.SetActive(false);
        playerResourcesPanel.SetActive(true);
        playerInventoryPanel.SetActive(false);
    }

    public void TogglePlayerInventoryPanel()
    {
        playerAttributesPanel.SetActive(false);
        playerResourcesPanel.SetActive(false);
        playerInventoryPanel.SetActive(true);
    }

}
