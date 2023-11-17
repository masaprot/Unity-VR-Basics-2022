using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    // NAPPULA ERI MATERIAALIKOKONAISUUKSILLE : Neutraali, Värikäs (tai Puu/Vihreä) , Tumma.


    public List<MaterialController> controlledMeshes; // ovet

    public List<KnobMaterialController> controlledKnobMeshes; // nappivetimet

    public List<HandleMaterialController> controlledHandleMeshes; // kahvat

    public List<TapMaterialController> controlledTapMeshes; //hana

    public List<TasoMaterialController> controlledTasoMeshes; //taso

    public List<PeitelevyMaterialController> controlledPeitelevyMaterial; // peitelevy

    //Ovi materiaalit
    public Material mattaVaaleanpunainen;
    public Material mattaValkoinen;

    //Nuppi & Kahva & Hana Materiaalit
    public Material puu;
    public Material metalli;
    public Material messinki;
    public Material mattaPunainen;

    //Taso Materiaalit
    public Material mattaSininen;


    public void ChangeToVärikäs()
    {
        foreach (var MaterialController in controlledMeshes)
        {
            MaterialController.controlledMesh.material = mattaVaaleanpunainen;
        }

        foreach (var KnobMaterialController in controlledKnobMeshes)
        {
            KnobMaterialController.controlledKnobMesh.material = puu;
        }

        foreach (var HandleMaterialController in controlledHandleMeshes)
        {
            HandleMaterialController.controlledHandleMesh.material = mattaPunainen;
        }

        foreach (var TapMaterialController in controlledTapMeshes)
        {
            TapMaterialController.controlledTapMesh.material = mattaPunainen;
        }

        foreach (var TasoMaterialController in controlledTasoMeshes)
        {
            TasoMaterialController.controlledTasoMesh.material = mattaSininen;
        }

        foreach (var PeitelevyMaterialController in controlledPeitelevyMaterial)
        {
            PeitelevyMaterialController.controlledPeitelevyoMesh.material = puu;

        }
    }



}





    /*TÄLLÄ SKRIPTILLÄ VAIN VAIHDETTIIN OVIEN VÄRIÄ
     * 
     * public List<MaterialController> controlledMeshes;

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
    }*/