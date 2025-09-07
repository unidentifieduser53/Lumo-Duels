using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoveanim : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float currentloc=0f;
    public Transform tranloc;
    public Animator enemyanim;
    void Start()
    {
        enemyanim=GetComponent<Animator>();
        tranloc = GetComponent<Transform>();
        currentloc=tranloc.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Tran "+tranloc.position.x);
        Debug.Log("Curr "+currentloc);
        
        if(currentloc > tranloc.position.x)
        {
            enemyanim.SetBool("isWalking",true);
        }
        else{
            enemyanim.SetBool("isWalking",false);
        }
        
    }
}
