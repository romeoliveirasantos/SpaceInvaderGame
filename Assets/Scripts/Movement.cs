using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float MoveSpeed = 10f;
    public static int PlayerLife = 10;
    public static int fuelSpaceship = 100;
    public float timerSpeed;
    public static float timerCount;
    public float timerCountFuel;
   

    public int VidaConsole = PlayerLife;
    public float MoveSpeedConsole = Movement.MoveSpeed;
    public int fuelConsole;

    public List<GameObject> bullets = new List<GameObject>();


    public string BulletName;
    public GameObject BulletType;
    public float bulletSpeed;


    Vector3 Xposition;
    public float NewXposition;

    public GameObject spawnerbullet1;
    public GameObject spawnerbullet2;
    public GameObject spawnerbullet3;
    public GameObject spawnerbullet4;
    public GameObject spawnerbullet5;
    public GameObject spawnerbullet6;
    public GameObject spawnerbullet7;

   



    //public GameObject LifeRepair;
    //public GameObject SpeedBoost;
    //public GameObject Fuel;





    void Start()
    {
        Xposition = new Vector3(3.0f, 0.0f, 0.0f);
       
    }
    
   

    void Update()
    {


        

    fuelConsole = fuelSpaceship;
    //fuel spent
        timerCountFuel += Time.deltaTime;
        if(timerCountFuel  >= 50f)
        {
            fuelSpaceship += -10;
            timerCountFuel = 0f;
        }
        //debuf movespeed
        if(fuelSpaceship <= 0)
        {
            MoveSpeed = 1f;
        }
       



        // Player controller 
        if (PlayerLife >= 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
            }

            //dash
            if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * MoveSpeed);
            }

            if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * MoveSpeed);
            }

        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
            {
              BulletType = bullets[0];
              BulletName = "BluePoint";
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            BulletType = bullets[1];
            BulletName = "RedPoint";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            BulletType = bullets[2];
            BulletName = "GreenPoint";
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(BulletName == "BluePoint")
            {
              Instantiate(bullets[0], spawnerbullet4.transform.position, spawnerbullet4.transform.rotation);
                
            }

            if(BulletName  == "RedPoint")
            {
                Instantiate(bullets[1], spawnerbullet3.transform.position, spawnerbullet3.transform.rotation);
                Instantiate(bullets[1], spawnerbullet4.transform.position, spawnerbullet4.transform.rotation);
                Instantiate(bullets[1], spawnerbullet5.transform.position, spawnerbullet5.transform.rotation);
            }

            if (BulletName == "GreenPoint")
            {
                Instantiate(bullets[2], spawnerbullet1.transform.position, spawnerbullet1.transform.rotation); ;
                Instantiate(bullets[2], spawnerbullet2.transform.position, spawnerbullet2.transform.rotation);
                Instantiate(bullets[2], spawnerbullet3.transform.position, spawnerbullet3.transform.rotation);
                Instantiate(bullets[2], spawnerbullet4.transform.position, spawnerbullet4.transform.rotation);
                Instantiate(bullets[2], spawnerbullet5.transform.position, spawnerbullet5.transform.rotation);
                Instantiate(bullets[2], spawnerbullet6.transform.position, spawnerbullet6.transform.rotation);
                Instantiate(bullets[2], spawnerbullet1.transform.position, spawnerbullet7.transform.rotation);
            }
        }

    }
   
  

    
}
