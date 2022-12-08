using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerSceneChanger : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            if(other.name == "GuardCastle" && Triggers.Forest && Triggers.Desert && Triggers.Graveyard)
            {
                SceneManager.LoadScene("Castle");
            }
            if(other.name == "GuardDesert" && Triggers.Forest && !Triggers.Desert)
            {
                SceneManager.LoadScene("Maze");
            }
            if(other.name == "GuardForest" && !Triggers.Forest)
            {
                SceneManager.LoadScene("Forest");
            }
            if(other.name == "BarnForest" && Triggers.Forest)
            {
                SceneManager.LoadScene("ForestCleansed");
            }
            if(other.name == "GuardGraveyard" && Triggers.Forest && Triggers.Desert && !Triggers.Graveyard)
            {
                SceneManager.LoadScene("Graveyard");
            }
            if(other.name == "ForestHub" && Triggers.Forest)
            {
                SceneManager.LoadScene("Hub");
            }
            if(other.name == "DesertHub" && Triggers.Desert)
            {
                SceneManager.LoadScene("Hub");
            }
            if(other.name == "GraveyardHub" && Triggers.Graveyard)
            {
                SceneManager.LoadScene("Hub");
            }
            if(other.name == "CastleHub")
            {
                SceneManager.LoadScene("Hub");
            }
            if(other.name == "Barn")
            {
                SceneManager.LoadScene("Barn");
            }
            print(other.name);
        }
    }
}
