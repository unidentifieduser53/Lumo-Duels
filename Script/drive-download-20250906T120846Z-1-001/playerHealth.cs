using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    
    public int maxHealth = 100;
    public int currentHealth;

    

    void Start()
    {
        // Initialize player's health to the maximum value
        currentHealth = maxHealth;
    }

   

    // Method to apply damage to the player
    public void TakeDamage(int damage)
    {
        // Reduce health by the damage amount
        currentHealth -= damage;

        // Make sure health doesn't drop below zero
        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            Debug.Log("Player took damage, current health: " + currentHealth);
        }
    }

    // This method is called when the player's health reaches 0
    private void Die()
    {
        Debug.Log("Player has died!");
        // You can add any death logic here, like playing an animation, restarting the level, etc.
        // Destroy the player for now (optional)
        Destroy(gameObject);
    }
}
