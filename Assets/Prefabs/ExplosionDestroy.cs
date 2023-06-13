using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour
{

    public GameObject bullet;
    public GameObject player;
    public float velocidade;
    
    void Start()
    {
        
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, player.transform.position, player.transform.rotation * Quaternion.identity);
        }

        
    }
}

    
    

  

