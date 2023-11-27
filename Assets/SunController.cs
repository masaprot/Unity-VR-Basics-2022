using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{

    public bool isDay;


    void Update()
    {
        if (isDay == true)
        {
            RotateDay();
        }
        else
        {
            RotateNight();
        }

    }

    public void ToggleDayNight()
    {
        if (isDay == true)
            isDay = false;
        else
            isDay = true;

    }

    void RotateDay()
    {
        Vector3 rotationToAdd = new Vector3(120, 0, 0);
        transform.Rotate(rotationToAdd);
    }

    void RotateNight()
    {
        Vector3 rotationToAdd = new Vector3(-10, 0, 0);
        transform.Rotate(rotationToAdd);
    }

   
}
