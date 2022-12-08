using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubSpawnControl : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform NorthSpawnPoint;
    [SerializeField] private Transform EastSpawnPoint;
    [SerializeField] private Transform SouthSpawnPoint;
    [SerializeField] private Transform WestSpawnPoint;


    // Start is called before the first frame update

    void Start()
    {
        if(Triggers.Graveyard == true){
            westSpawn();
        }
        else if(Triggers.Desert == true){
            eastSpawn();
        }
        else if(Triggers.Forest == true){
            southSpawn();
        }
        else {
            northSpawn();
        }
        
    }

    public void northSpawn(){
        player.transform.position = NorthSpawnPoint.transform.position;
        Physics.SyncTransforms();
    }

    public void eastSpawn(){
        player.transform.position = EastSpawnPoint.transform.position;
        Physics.SyncTransforms();
    }

    public void southSpawn(){
        player.transform.position = SouthSpawnPoint.transform.position;
        Physics.SyncTransforms();
    }

    public void westSpawn(){
        player.transform.position = WestSpawnPoint.transform.position;
        Physics.SyncTransforms();
    }

}
