using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePointScript : MonoBehaviour
{
    public int vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * vel * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
