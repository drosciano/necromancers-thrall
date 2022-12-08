using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleBravo : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject enemy9;

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
            Destroy(enemy7);
            Destroy(enemy8);
            Destroy(enemy9);
        }
    }
}
