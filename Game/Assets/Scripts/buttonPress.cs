using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

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
                anim.SetBool("isBlueButtonDown", true);  
            }
        }
        else if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("redBox"))
            {
               anim.SetBool("isRedButtonDown", true);  
            }
           
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (gameObject.CompareTag("blueButton"))
        {
            if(other.gameObject.CompareTag("blueBox"))
            {
                anim.SetBool("isBlueButtonDown", false);
            }
        }
        else if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("redBox"))
            {
                anim.SetBool("isRedButtonDown", false);  
            }
           
        }
    }
}
