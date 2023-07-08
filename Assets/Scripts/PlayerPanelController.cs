using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPanelController : MonoBehaviour
{
    public GameObject playerAttributesPanel;
    public GameObject playerResourcesPanel;

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
    }

    public void TogglePlayerResourcePanel()
    {
        playerAttributesPanel.SetActive(false);
        playerResourcesPanel.SetActive(true);
    }

}
