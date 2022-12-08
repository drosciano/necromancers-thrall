using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesertCutsceneTimer : MonoBehaviour
{

    float currentTime;
    public float startingTime = 23f;
    private bool finished = false;
    private bool startTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        startTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(startTimer){
            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 0){
                SceneManager.LoadScene("MazeComplete");
                finished = true;
            }
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadScene("MazeComplete");
        }
    }
}
