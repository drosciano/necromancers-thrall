using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
        SceneManager.LoadScene("Castle");
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
        SceneManager.LoadScene("Hub");
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
        SceneManager.LoadScene("Maze");
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
        SceneManager.LoadScene("Forest");
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)){
        SceneManager.LoadScene("Graveyard");
        }
        if(Input.GetKey(KeyCode.Alpha0)){
        SceneManager.LoadScene("Barn");
        }
    }
}
