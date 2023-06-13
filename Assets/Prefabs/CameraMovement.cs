using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject playerFollow;
    public float speed;
    public bool isMoving;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        isMoving = false;

        if (Input.GetKey(KeyCode.D))
        {
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.W))
        {
            isMoving = true;
        }

        if (isMoving == true) 
        {
            speed = 0.3f;
        transform.Translate(playerFollow.transform.position * speed * Time.deltaTime);
        }
      
        
        
    }
}
