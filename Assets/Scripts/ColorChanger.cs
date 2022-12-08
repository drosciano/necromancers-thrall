using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorChanger : MonoBehaviour
{
    private bool isCleansed;
    public GameObject tree;
    public Material treeMaterial;
    private Terrain floor;
    
    public GameObject Barn;
    
    // Start is called before the first frame update
    void Start()
    {
       
        if (SceneManager.GetActiveScene().name == "Forest")
        {
            Triggers.Forest = false;
        Debug.Log(SceneManager.GetActiveScene().name);
        }
        if (SceneManager.GetActiveScene().name == "ForestCleansed")
        {
            Triggers.Forest = true;
            Debug.Log(SceneManager.GetActiveScene().name);
        }
        isCleansed = Triggers.Forest;
        floor = Terrain.activeTerrain;
        changeSceneColor();
    }

    // Update is called once per frame
    void Update()
    {
        isCleansed = Triggers.Forest;
        changeSceneColor();
        Ramp1();
        Ramp2();
        Ramp3();
    }
        

    void changeSceneColor()
    {
        if (SceneManager.GetActiveScene().name == "Forest" || SceneManager.GetActiveScene().name == "ForestCleansed")
        {
            if (isCleansed) {
                treeMaterial.color = Triggers.cleansed;
                floor.terrainData.terrainLayers[0].diffuseRemapMax = Triggers.cleansed;
            }
            else 
            {
                treeMaterial.color = Triggers.corrupted;
                floor.terrainData.terrainLayers[0].diffuseRemapMax = Triggers.corrupted;
            }
        }
    }

    void Ramp1() 
    {
        GameObject destRamp1 = GameObject.Find("DestRamp1");
        if (Triggers.ramp1 && GameObject.Find("DestRamp1") != null) 
        {
            Destroy(destRamp1.gameObject); 
        }
    }

    void Ramp2() 
    {
        GameObject destRamp2 = GameObject.Find("DestRamp2");
        if (Triggers.ramp2 && GameObject.Find("DestRamp2") != null) 
        {
            Destroy(destRamp2.gameObject); 
        }
    }

    void Ramp3() 
    {
        GameObject destRamp3_1 = GameObject.Find("DestRamp3.1");
        GameObject destRamp3_2 = GameObject.Find("DestRamp3.2");
        if (Triggers.ramp3 && GameObject.Find("DestRamp3.1") != null) 
        {
            Destroy(destRamp3_1.gameObject); 
        }
        if (Triggers.ramp3 && GameObject.Find("DestRamp3.2") != null) 
        {
            Destroy(destRamp3_2.gameObject); 
        }
    }

}
