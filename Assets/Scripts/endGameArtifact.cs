using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGameArtifact : MonoBehaviour
{
    public GameObject gameEnd;
    public GameObject enemyCount;
    private bool triggerEnter = false;

    public GameObject messageUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && enemyCount.transform.childCount == 0)
        {
            triggerEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        triggerEnter = false;
    }

    void Start()
    {
        messageUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerEnter == true)
        {
            messageUI.SetActive(true);
        }

        if (triggerEnter == false)
        {
            messageUI.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E) && triggerEnter == true)
        {
            Destroy(gameEnd);
            gameObject.GetComponent<SphereCollider>().enabled = false;

            if (Triggers.moralityCheck >= 0)
            {
                SceneManager.LoadScene("Good_Ending");
            }
            else
            {
                SceneManager.LoadScene("Bad_Ending");
            }
        }

        if (gameObject.GetComponent<SphereCollider>().enabled == false)
        {
            messageUI.SetActive(false);
        }

    }
}
