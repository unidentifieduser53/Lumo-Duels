using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScript : MonoBehaviour
{
        // This function is called when another object enters the collider attached to the game object this script is on
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the game object that collided has the tag "Bullet"
        if (collision.gameObject.CompareTag("bullet"))
        {
            // Destroy this game object (the one this script is attached to)
            Destroy(gameObject);

            // Optionally, you can also destroy the bullet itself
            Destroy(collision.gameObject);
        }
    }

}
