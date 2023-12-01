using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DrawerController : MonoBehaviour
{
    public GameObject controlledMesh;
    public Vector3 open;
    public Vector3 closed;
    public bool isOpen;
    float timer;
    public float duration = 1;



    void Start()
    {

    }

    private void Update()
    {
        if (isOpen && timer < 1f)
        {
            timer += Time.deltaTime / duration;
            if (timer > 1) timer = 1; // is we're ar or between 0 and 1
            controlledMesh.transform.position = Vector3.Lerp(closed, open, timer);
        }
        else if (isOpen == false && timer > 0f)
        {
            timer -= Time.deltaTime / duration;
            if (timer < 0) timer = 0; // is we're ar or between 0 and 1
            controlledMesh.transform.position = Vector3.Lerp(closed, open, timer);
        }
    }

    public void OpenDrawer()
    {
        if (isOpen == true)
            isOpen = false;
        else
            isOpen = true;

    }

    /*
    void Open()
    {
        controlledMesh.transform.position = open;
    }

    void Closed()
    {
        controlledMesh.transform.position = closed;

    }
    */
}
