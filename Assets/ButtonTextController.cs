using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTextController : MonoBehaviour
{
    public TMP_Text controlledText;
    public Color unselected, selected;
    public bool isSelected;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected == true)
            Selected();
        else
            Unselected();
    }

    public void ToggleTextColor()
    {
        if (isSelected == true)
            isSelected = false;
        else
            isSelected = true;
    }

    void Unselected()
    {
        controlledText.color = unselected;
    }

    void Selected()
    {
        controlledText.color = selected;
    }
}
