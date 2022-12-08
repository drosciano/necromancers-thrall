using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellTeleport : MonoBehaviour
{
    public GameObject enemyCount;
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player" && enemyCount.transform.childCount == 0)
        {
            GameObject.Find("PlayerArmature").SendMessage("Complete");
        }
    }
}
