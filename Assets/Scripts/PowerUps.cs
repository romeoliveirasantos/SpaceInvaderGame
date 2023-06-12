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
        LifeRecharger = GameObject.FindGameObjectWithTag("SpeedBoost");
        FuelRecharger = GameObject.FindGameObjectWithTag("SpeedBoost");


        Debug.Log(Movement.MoveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D BoostColisions)
    {

        if (GameObject.FindGameObjectWithTag("SpeedBoost"))
        {
            if (Movement.MoveSpeed <= 10f) 
            {
            Movement.MoveSpeed = 40f;
            }
            Destroy(SpeedBoost);
  
        }

        if (GameObject.FindGameObjectWithTag("LifeRecharge"))
        {
            if(Movement.PlayerLife <= 9)
            {
                if(Movement.MoveSpeed > 10f) 
                {
                Movement.MoveSpeed = 10f;
                }
                Movement.PlayerLife++;
                Destroy(LifeRecharger);
            }
        }

        if (GameObject.FindGameObjectWithTag("FuelRecharge"))
        {
            if (Movement.MoveSpeed > 10f)
            {
                Movement.MoveSpeed = 10f;
            }
            Movement.fuelSpaceship += 10;
            Destroy(FuelRecharger);
        }

    }
}

