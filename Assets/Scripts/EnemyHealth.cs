using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float currentHealth = 100f;
    public float maxHealth = 100f;
    public GameObject enemy;
    

    static public bool dead = false;

    // Update is called once per frame
    void Update()
    {
        dead = false;
        AdjustCurrentHealth(0);
        if (dead)
        {
            // Debug.Log("Enemy died");
            Animator anim = enemy.GetComponent<Animator>();
            anim.SetBool("isRunning", false);
            anim.SetBool("Death", true);
            Destroy(enemy.gameObject, 5);
        }
    }

    public void AdjustCurrentHealth(float adj)
    {
        currentHealth += adj;
        
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            Animator anim = enemy.GetComponent<Animator>();
            anim.SetTrigger("Death");
            dead = true;
            // Debug.Log(gameObject.name + " is Dead");
        }
        else if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(maxHealth < 1)
        {
            maxHealth = 1;
        }
        if(adj != 0)
        {
            Debug.Log("Damage Dealt = " + adj);
        }
    }
}
