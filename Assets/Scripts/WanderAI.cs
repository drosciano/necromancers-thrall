using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAI : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotSpeed = 100f;

    Animator anim;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    public CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isWandering == false) 
        {
            StartCoroutine(Wander());
        }
        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }
        if (isWalking == true)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            controller.Move(transform.forward * moveSpeed * Time.deltaTime);
        }
    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 2);
        int rotateWait = Random.Range(1, 10);
        int rotateLorR = Random.Range(1,2);
        int walkWait = Random.Range(1, 8);
        int walkTime = Random.Range(1,12);

        isWandering = true;
        anim.SetBool("isWandering", isWandering);

        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        anim.SetBool("isWalking", isWalking);
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        anim.SetBool("isWalking", isWalking);
        yield return new WaitForSeconds(rotateWait);
        if(rotateLorR == 1)
        {
            isRotatingRight = true;
            anim.SetBool("isRotatingRight", isRotatingRight);
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
            anim.SetBool("isRotatingRight", isRotatingRight);
        }
        if(rotateLorR == 2)
        {
            isRotatingLeft = true;
            anim.SetBool("isRotatingLeft", isRotatingLeft);
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
            anim.SetBool("isRotatingLeft", isRotatingLeft);
        }
        isWandering = false;
        anim.SetBool("isWandering", isWandering);
    }
}
