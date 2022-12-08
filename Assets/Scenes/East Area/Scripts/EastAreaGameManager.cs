using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EastAreaGameManager : MonoBehaviour
{
    float currentTime;
    public float startingTime = 240f;
    private bool finished = false;
    private bool startTimer = false;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public PlayerHealth playerHealth;
    
    
    [SerializeField] Text countdownText;

    void Start()
    {
        Triggers.Desert = false;
        currentTime = startingTime;
    }
    void Update()
    {
        if (finished)
        {
            return;
        }
        if(startTimer)
        {            
           currentTime -= 1 * Time.deltaTime;
           int seconds = ((int)currentTime % 60);
           int minutes = ((int)currentTime / 60);

           countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            
           //countdownText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {   Time.timeScale = 0;
                currentTime = 0;
                
                player.transform.position = respawnPoint.transform.position;
                Physics.SyncTransforms();
                currentTime = startingTime;
                startTimer = false;
                countdownText.text = "";
                countdownText.color = Color.white;
                Time.timeScale = 1;
                
            }
        }
    }

    public void Finish()
    {
        finished = true;
        countdownText.text = "";
    }

    public void StartTimer()
    {
        startTimer = true;
    }

    public void Complete()
    {
        Triggers.Desert = true;
        SceneManager.LoadScene("Desert_Cutscene");
    }
}
