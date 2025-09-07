using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int spawnctr = 0;
    public int wavectr = 0;
    public int enemywave = 0;

    public int maxspawn=0;

    public int spawnpoint;

    public Transform spoint1;
    public Transform spoint2;
    public Transform spoint3;
    public Transform spoint4;

    public int ctr=0;

    public int spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        maxspawn=20;
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
   
    IEnumerator SpawnEnemies()
    {
        for (spawnctr=1; spawnctr <=maxspawn; spawnctr++)
        {
            // Generate a random position
           Spawn();
            // Wait for the specified delay before spawning the next one
            spawnDelay=Random.Range(1,5);
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    public void Spawn()
    {
            spawnpoint=Random.Range(0,3);
            if(spawnpoint == 0)
            {
                Instantiate(enemyPrefab,spoint1.position,Quaternion.identity);
            }
            if(spawnpoint == 1)
            {
                Instantiate(enemyPrefab,spoint2.position,Quaternion.identity);
            }
            if(spawnpoint == 2)
            {
                Instantiate(enemyPrefab,spoint3.position,Quaternion.identity);
            }
            if(spawnpoint == 3)
            {
                Instantiate(enemyPrefab,spoint4.position,Quaternion.identity);
            }
    }
   
}
