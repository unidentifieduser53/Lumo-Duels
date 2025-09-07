using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class enemyHealth : MonoBehaviour
{
  
    public int emaxHealth = 100;
    public int ecurrentHealth;

    public gameobjectstat objectstat;
        
    public int tdamage;

    public GameObject popUpDamagePrefab;
    public Transform popupPos;
    public TMP_Text popUpText;
    
    void Start()
    {
        // Initialize player's health to the maximum value
        ecurrentHealth = emaxHealth;
    }

     private void OnCollisionEnter(Collision other)
    {
        // Check if the object that entered the trigger has a specific tag (optional)
        if (other.gameObject.CompareTag("bullet"))
        {
            objectstat = other.gameObject.GetComponent<gameobjectstat>();
            tdamage = objectstat.atkdamage;  
            TakeDamage(tdamage);
        }
    }
    // Method to apply damage to the player
    public void TakeDamage(int damage)
    {
        // Reduce health by the damage amount
        ecurrentHealth -= damage;
        popUpText.text = damage.ToString();
        Instantiate(popUpDamagePrefab,popupPos.position,Quaternion.identity);

        // Make sure health doesn't drop below zero
        if (ecurrentHealth <= 0)
        {
            Die();
        }
        else
        {
            Debug.Log("Enemy took damage, current health: " + ecurrentHealth);
        }
    }

    // This method is called when the player's health reaches 0
    private void Die()
    {
        Debug.Log("Enemy has died!");
        // You can add any death logic here, like playing an animation, restarting the level, etc.
        // Destroy the player for now (optional)
        Destroy(gameObject);
    }
}
