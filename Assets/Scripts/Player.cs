using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D PlayerRig;
    public float velocity;
    private Vector2 PlayerDirection;
    public GameObject bulletObject, spawnerBulletPos;
    public static int PlayerLife;
    
    
    
    


    // Start is called before the first frame update
    void Start()
    {
        PlayerRig = GetComponent<Rigidbody2D>();
        PlayerLife = 10;
     
        
    } 

    // Update is called once per frame
    void Update()
    {
        PlayerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //PlayerRig.MovePosition(PlayerRig.position + PlayerDirection * velocity * Time.deltaTime);
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = direction;
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Instantiate(bulletObject, spawnerBulletPos.transform.position, this.gameObject.transform.rotation);
        }

        Debug.Log(PlayerLife);

        if(PlayerLife <= 0)
        {
            Debug.Log("Você Morreu");
            Destroy(gameObject);
        }

    }

    private void FixedUpdate()
    {
        PlayerRig.MovePosition(PlayerRig.position + PlayerDirection * velocity * Time.fixedDeltaTime);
    }

   
}
