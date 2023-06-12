using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMenssages : MonoBehaviour
{
    public List<string> NpcMessages = new List<string>();
    public float timer;
    public int rangePlayers;
    void Start()
    {
        timer = 0f;
    }

    
    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;
        if (timer >= 10 && rangePlayers == 6)
        {
            Debug.Log(NpcMessages[Random.Range(0,NpcMessages.Count)]);
            timer = 0f;
        }
        
    }
}
