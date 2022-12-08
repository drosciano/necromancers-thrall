using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            TakeDamage(20);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        if (currentHealth <= 0)
        {
            Time.timeScale = 0;
            Respawn();
        }

        healthBar.SetHealth(currentHealth);
    }

    public void Respawn()
    {
        player.transform.position = respawnPoint.transform.position;
        Physics.SyncTransforms();
        currentHealth = maxHealth;
        Time.timeScale = 1;
    }
}
