using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public List<MaterialController> controlledMeshes;

    public Material valkoinenMaterial;
    public Material vihreaMaterial;
    public Material harmaaMaterial;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeToValkoinen()
    {
        foreach (var materialController in controlledMeshes)
        {
            materialController.controlledMesh.material = valkoinenMaterial;
        }
    }

    public void ChangeToVihreä()
    {
        foreach (var materialController in controlledMeshes)
        {
            materialController.controlledMesh.material = vihreaMaterial;
        }
    }

    public void ChangeToHarmaa()
    {
        foreach (var materialController in controlledMeshes)
        {
            materialController.controlledMesh.material = harmaaMaterial;
        }
    }

}