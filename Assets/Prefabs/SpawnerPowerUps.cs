using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPowerUps : MonoBehaviour
{
    public List<GameObject> PowerUps = new List<GameObject>();

    public float timerSpawnerPowerUp;
    public float timeToSpawn;

    public GameObject LifeRepair;
    public GameObject SpeedBoost;
    public GameObject Fuel;
    public static GameObject objetoInstanciado;
    public static bool IsInstantiate;


    void Start()
    {
        IsInstantiate = true;
        objetoInstanciado = Instantiate(PowerUps[Random.Range(0, PowerUps.Count)], gameObject.transform.position, gameObject.transform.rotation);
    }

    
    void Update()
    {

        
        timerSpawnerPowerUp += Time.deltaTime;

        if(timerSpawnerPowerUp >= timeToSpawn) 
        {
            

            if(IsInstantiate == false) 
            { 
               objetoInstanciado  =  Instantiate(PowerUps[Random.Range(0,PowerUps.Count)],gameObject.transform.position, gameObject.transform.rotation);
               timerSpawnerPowerUp = 0f;
               IsInstantiate = true;
            }
           
        }
    }


}
