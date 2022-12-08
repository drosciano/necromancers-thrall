using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemies : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Destroy(enemy1);
            Destroy(enemy2);
            Destroy(enemy3);
            Destroy(enemy4);
            Destroy(enemy5);
            Destroy(enemy6);
        }
    }
}
