using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestArtifact : MonoBehaviour
{
    public GameObject artifact;
    private bool triggerEnter = false;
    

    public GameObject messageUI;

    public float degreesPerSecond = 20;

    public GameObject artRespawn;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
        Triggers.barn = false;
        if (Triggers.Forest)
        {
            player.transform.position = artRespawn.transform.position;
            Physics.SyncTransforms();
            Destroy(artifact);
        }
        Triggers.Forest = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
        
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
            // artifact.GetComponent<Renderer>().enabled = false;
            // gameObject.GetComponent<SphereCollider>().enabled = false;
            
            Triggers.Forest = true;
            
            Destroy(artifact);
            triggerEnter = false;
            SceneManager.LoadScene("Forest_Cutscene");
            triggerEnter = false;            
        }
        
        if (triggerEnter == false)
        {
            messageUI.SetActive(false);
        }
        
    }

    

    void OnTriggerEnter(Collider other)
    {
        triggerEnter = true;
    }

    void OnTriggerExit(Collider other) 
    {
        triggerEnter = false;
    }
}
