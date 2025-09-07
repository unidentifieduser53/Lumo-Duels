using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemove : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    // Start is called before the first frame update
   private float currentloc=0f;
   private Transform tranloc;

    public int estate = 0;

    public float damage = 10f; // Damage dealt to the player
    
    private Transform lastloc;
    
    void Start()
    {
        // Find the player's health script
        tranloc = GetComponent<Transform>();
        lastloc = tranloc;
        currentloc=tranloc.position.x;
        estate = 0;
    
    }

    // Update is called once per frame
    void Update()
    {
        if(estate==0)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            currentloc=tranloc.position.x;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
    if (collision.gameObject.CompareTag("Player"))
        {
          estate = 1;
          //Destroy(collision.gameObject);
        }
        else
        {
            estate=0;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
    if (collision.gameObject.CompareTag("Player"))
        {
          estate = 0;
          //Destroy(collision.gameObject);
        }
    }
 }
