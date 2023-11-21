using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    private TextMeshPro buttonText;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectedColor()
    {
        buttonText = GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();
        buttonText.color = Color.white;
    }

    public void UnselectedColor()
    {
        buttonText = GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();
        buttonText.color = Color.grey;
    }

}
