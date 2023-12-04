using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject panel;


    private void Start()
    {
        panel.SetActive(false);
    }

    public void OpenPanel()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            
            panel.SetActive(!isActive);

        }

    }

    public void HidePanel()
    {
        panel.SetActive(false);

    }
}
