using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleRectTransform;

    Toggle toggle;

    Vector2 handlePosition;

    void Awake()
    {
        toggle = GetComponent<Toggle>();

        handlePosition = uiHandleRectTransform.anchoredPosition;

        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
            OnSwitch(true);
    }


    void OnSwitch(bool on)
    {
        if (on)
            uiHandleRectTransform.anchoredPosition = handlePosition * -1;
        else
            uiHandleRectTransform.anchoredPosition = handlePosition;



    }
    void OnDestroy()
    {
        toggle.onValueChanged.RemoveListener (OnSwitch);
    }



}
