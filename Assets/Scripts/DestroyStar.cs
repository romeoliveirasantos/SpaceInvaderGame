using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStar : MonoBehaviour
{
    public float timerDestroyStar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerDestroyStar += Time.deltaTime;
        if(timerDestroyStar >= 2f)
        {
            Destroy(gameObject);
        }
    }
}
