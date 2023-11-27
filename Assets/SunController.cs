using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SunController : MonoBehaviour
{
    public Light sun;
    public Vector3 dayEuler, nightEuler;
    Quaternion dayRotation, nightRotation;
    public float duration = 1;
    float timer;
    bool fadeUp;

    private void Awake()
    {
        dayRotation = Quaternion.Euler(dayEuler);
        nightRotation = Quaternion.Euler(nightEuler);
    }


    private void Update()
    {
        if (fadeUp && timer < 1f)
        {
            timer += Time.deltaTime / duration;
            if (timer > 1) timer = 1; // is we're ar or between 0 and 1
            sun.transform.rotation = Quaternion.Slerp(nightRotation, dayRotation, timer);
        }
        else if (fadeUp == false && timer > 0f)
        {
            timer -= Time.deltaTime / duration;
            if (timer < 0) timer = 0; // is we're ar or between 0 and 1
            sun.transform.rotation = Quaternion.Slerp(nightRotation, dayRotation, timer); 
        }    
    }

    public void ToggleDayNight()
    {
        if (fadeUp == true)
            fadeUp = false;
        else
            fadeUp = true;
    }






    /*public bool isDay;


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
    */

}
