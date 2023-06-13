using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public float timerCount;
    public bool timerBosted = false;
    private GameObject SpeedBoost;
    private GameObject LifeRecharger;
    private GameObject FuelRecharger;
    private GameObject playerSpaceship;
    private GameObject OBETO;




    public enum PowerUpsEspecials
    {
        LifeRepair,
        SpeedBoost,
        FuelRecharger
    }
    public PowerUpsEspecials powerUps;
    void Start()
    {

        

    }


    void Update()
    {


        
        SpeedBoost = GameObject.FindGameObjectWithTag("SpeedBoost");
        LifeRecharger = GameObject.FindGameObjectWithTag("LifeRecharge");
        FuelRecharger = GameObject.FindGameObjectWithTag("FuelRecharge");
        playerSpaceship = GameObject.FindGameObjectWithTag("PlayerSpaceShip");
        OBETO = GameObject.FindGameObjectWithTag("OBETO");


        Debug.Log(playerSpaceship);
    }
    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D BoostColisions)
    {
        
       
          
        
    }
}

