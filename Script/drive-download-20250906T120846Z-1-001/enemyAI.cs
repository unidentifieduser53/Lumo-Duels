using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
   // Reference to the Animator component
    public Transform currPos;
    public Transform lastPos;
    private Animator animator;
    // Enemy states
    public enum EnemyState { Idle, Walk, Attack, Die };
    public EnemyState currentState;

    public playerHealth Playerhealth;

    public int damageAmount;
    public bool atkon=false;

    void Start()
    {
        // Get the Animator component attached to the enemy
        animator = GetComponent<Animator>();
        currPos = GetComponent<Transform>();
        SetEnemyState(1);
               
    }

    void Update()
    {
       
        // Update animation based on the current state
        switch (currentState)
        {
            case EnemyState.Idle:
                PlayIdle();
                break;
            case EnemyState.Walk:
                PlayWalk();
                break;
            case EnemyState.Attack:
                PlayAttack();
                break;
            case EnemyState.Die:
                PlayDie();
                break;
        }
    }

    // Play the Idle animation
    void PlayIdle()
    {
        animator.Play("Idle");
    }

    // Play the Walk animation
    void PlayWalk()
    {
        animator.Play("Walk");
    }

    // Play the Attack animation
    void PlayAttack()
    {
        animator.Play("Attack");
    }

    // Play the Die animation
    void PlayDie()
    {
        animator.Play("Die");
    }

    // Optional: To set the enemy state from outside this script
    public void SetEnemyState(int state)
    {
        currentState = (EnemyState)state;
    }
     private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has a specific tag (optional)
        if (other.CompareTag("Player"))
        {
            // Example action: Log a message when the player enters the trigger
            Debug.Log("Enemy Attack!!!");
            SetEnemyState(2);
            Playerhealth = other.gameObject.GetComponent<playerHealth>();
            if (Playerhealth != null)
               {
                    Playerhealth.TakeDamage(damageAmount);
               }
            // Example action: Destroy the object that entered the trigger
            // Destroy(other.gameObject);

            // Example action: You can interact with the other object
            // other.GetComponent<SomeComponent>().SomeMethod();
        }
    }
     private void OnTriggerExit(Collider other)
    {
        // Check if the object that entered the trigger has a specific tag (optional)
        if (other.CompareTag("Player"))
        {
              SetEnemyState(1);
              
        }
    }
}
