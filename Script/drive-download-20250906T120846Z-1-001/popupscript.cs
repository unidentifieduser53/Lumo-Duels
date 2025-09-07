using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupscript : MonoBehaviour
{
    public float textlifetime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, textlifetime);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
