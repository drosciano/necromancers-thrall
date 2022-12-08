using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrownPickUp : MonoBehaviour
{
    public GameObject crown;
    private bool triggerEnter = false;

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    public GameObject messageUI;

    public GameObject enemyCount;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && enemyCount.transform.childCount == 0)
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
        if (Triggers.Graveyard == true)
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            Destroy(enemy1);
            Destroy(enemy2);
            Destroy(enemy3);
            Destroy(enemy4);
            Destroy(enemy5);
            Destroy(enemy6);
            crown.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<SphereCollider>().enabled = false;
            if (gameObject.GetComponent<SphereCollider>().enabled == false)
            {
                messageUI.SetActive(false);
            }
        }
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
            crown.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<SphereCollider>().enabled = false;
            Triggers.Graveyard = true;
            SceneManager.LoadScene("Graveyard_Cutscene");

        }
        
        if (gameObject.GetComponent<SphereCollider>().enabled == false)
        {
            messageUI.SetActive(false);
        }
        
    }
}
