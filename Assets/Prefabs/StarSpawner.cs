using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject star;
    public float timerSpawnStar;
    public float timeToSpawn;
    void Start()
    {
        
    }

    
    void Update()
    {
        timerSpawnStar += Time.deltaTime;
        if (timerSpawnStar >= timeToSpawn)
        {
            Instantiate(star, gameObject.transform.position, gameObject.transform.rotation);
           
            timerSpawnStar = 0;
        }
    }
}
