using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    public GameObject Enemy;
    
    private static bool redButtonPressed;
    private static bool blueButtonPressed;
    private static bool enemiesNotYetSpawned;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        redButtonPressed = false;
        blueButtonPressed = false;
        enemiesNotYetSpawned = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesNotYetSpawned && redButtonPressed && blueButtonPressed)
        {
            //spawns two enemies at the specified locations
            Instantiate(Enemy, new Vector3(-4, 10, 0), Quaternion.identity); 
            Instantiate(Enemy, new Vector3(0, 2, 0), Quaternion.identity);           
    
            enemiesNotYetSpawned = false;    //sets to false so that they don't keep spawning
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (gameObject.CompareTag("blueButton"))
        {
            if(other.gameObject.CompareTag("blueBox"))
            {
                anim.SetBool("isBlueButtonDown", true);
                blueButtonPressed = true;
            }
        }
        else if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("redBox"))
            {
               anim.SetBool("isRedButtonDown", true);
               redButtonPressed = true;
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
                blueButtonPressed = false;
            }
        }
        else if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("redBox"))
            {
                anim.SetBool("isRedButtonDown", false);
                redButtonPressed = false;
            }
           
        }
    }
}
