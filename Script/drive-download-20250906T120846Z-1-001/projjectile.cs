using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projjectile : MonoBehaviour
{
    public float projectileSpeed = 20f;
    public float lifetime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
