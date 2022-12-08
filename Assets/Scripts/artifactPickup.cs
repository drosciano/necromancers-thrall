using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class artifactPickup : MonoBehaviour
{
    public GameObject key;
    public GameObject guard;
    private bool triggerEnter = false;

    public GameObject messageUI;

    void OnTriggerEnter(Collider other)
    {
        triggerEnter = true;
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
            key.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            guard.SetActive(true);
        }

        if (gameObject.GetComponent<BoxCollider>().enabled == false)
        {
            messageUI.SetActive(false);
        }

    }
}
