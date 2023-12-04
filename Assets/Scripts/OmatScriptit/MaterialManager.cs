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
    public Material mattaHarmaa;

    //Nuppi & Kahva & Hana Materiaalit
    public Material puu;
    public Material harjattumetalli;
    public Material mattaPunainen;

    //Taso Materiaalit
    public Material mattaSininen;
    public Material terrazzo;


    public void ChangeToVärikäs()
    {
        //Ovet & peitelevyt
        foreach (var MaterialController in controlledMeshes)
        {
            MaterialController.controlledMesh.material = mattaVaaleanpunainen;
        }
        //Nupit
        foreach (var KnobMaterialController in controlledKnobMeshes)
        {
            KnobMaterialController.controlledKnobMesh.material = puu;
        }
       // Vetimet
        foreach (var HandleMaterialController in controlledHandleMeshes)
        {
            HandleMaterialController.controlledHandleMesh.material = mattaPunainen;
        }
        //Taso
        foreach (var TasoMaterialController in controlledTasoMeshes)
        {
            TasoMaterialController.controlledTasoMesh.material = terrazzo;
        }
        //Hana
        foreach (var TapMaterialController in controlledTapMeshes)
        {
            TapMaterialController.controlledTapMesh.material = mattaPunainen;
        }

        /*foreach (var PeitelevyMaterialController in controlledPeitelevyMaterial)
        {
            PeitelevyMaterialController.controlledPeitelevyoMesh.material = puu;

        } */

    }

    public void ChangeToValkoinen()
    {
        //Ovet & peitelevyt
        foreach (var MaterialController in controlledMeshes)
        {
            MaterialController.controlledMesh.material = mattaValkoinen;
        }
        //Nupit
        foreach (var KnobMaterialController in controlledKnobMeshes)
        {
            KnobMaterialController.controlledKnobMesh.material = harjattumetalli;
        }
        // Vetimet
        foreach (var HandleMaterialController in controlledHandleMeshes)
        {
            HandleMaterialController.controlledHandleMesh.material = harjattumetalli;
        }
        //Taso
        foreach (var TasoMaterialController in controlledTasoMeshes)
        {
            TasoMaterialController.controlledTasoMesh.material = harjattumetalli;
        }
        //Hana
        foreach (var TapMaterialController in controlledTapMeshes)
        {
            TapMaterialController.controlledTapMesh.material = harjattumetalli;
        }

    }

    public void ChangeToTumma()
    {
        //Ovet & peitelevyt
        foreach (var MaterialController in controlledMeshes)
        {
            MaterialController.controlledMesh.material = mattaHarmaa;
        }
        //Nupit
        foreach (var KnobMaterialController in controlledKnobMeshes)
        {
            KnobMaterialController.controlledKnobMesh.material = puu;
        }
        // Vetimet
        foreach (var HandleMaterialController in controlledHandleMeshes)
        {
            HandleMaterialController.controlledHandleMesh.material = puu;
        }
        //Taso
        foreach (var TasoMaterialController in controlledTasoMeshes)
        {
            TasoMaterialController.controlledTasoMesh.material = terrazzo;
        }
        //Hana
        foreach (var TapMaterialController in controlledTapMeshes)
        {
            TapMaterialController.controlledTapMesh.material = harjattumetalli;
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