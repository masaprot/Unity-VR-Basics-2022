using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light controlledLight;
    public bool isOn;

    public void ToggleLight()
    {

        if (isOn == true)
        {
            LightOff();
            isOn = false;
        }
        else
        {
            LightOn();
            isOn = true;
        }
    }


    void LightOn()
    {

        controlledLight.intensity = 1;

    }

    void LightOff()
    {
        controlledLight.intensity = 0;
    }

    
}
