using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanelController : MonoBehaviour
{
    public GameObject startPanel;

   
    void Start()
    {
        startPanel.SetActive(true);
    }

    public void HideStarPanel()
    {
        startPanel.SetActive(false);
    }
}
