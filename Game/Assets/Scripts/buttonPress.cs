using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (gameObject.CompareTag("blueButton"))
        {
            if(other.gameObject.CompareTag("blueBox"))
            {
                Debug.Log("Blue button");
            }
        }
        else if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("redBox"))
            {
                Debug.Log("Red button");
            }
        }
        
    }
    
}
