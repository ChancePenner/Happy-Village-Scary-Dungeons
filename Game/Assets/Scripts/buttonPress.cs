/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 buttonPress.cs
  * \Date:   12/01/2019
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class buttonPress : MonoBehaviour
{
    public GameObject Enemy;
    
    private static bool redButtonPressed;
    private static bool blueButtonPressed;
    private static bool enemiesNotYetSpawned;
    private Animator anim;
    public AudioSource buttonClick;
    public AudioClip buttonAudio;
    
    
    /*
    * @ pre none
    * @ param none
    * @ post Start is called before the first frame update
    * @ return none
    */
    void Start()
    {
        anim = GetComponent<Animator>();
        redButtonPressed = false;
        blueButtonPressed = false;
        enemiesNotYetSpawned = true;

    }

    /*
    * @ pre none
    * @ param none
    * @ post Update is called once per frame
    * @ return none
    */
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

    /*
    * @ pre none
    * @ param a 2d collider
    * @ post box puzzle: compare box color with button color
    * @ return none
    */
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
    
    /*
    * @ pre none
    * @ param a 2d collider
    * @ post box puzzle: compare box color with button color
    * @ return none
    */
    private void OnTriggerEnter2D(Collider2D other)
    {
        buttonClick.pitch = 1;        //button on pitch is normal pitch of audio clips
        
        if (gameObject.CompareTag("blueButton"))
        {
            if(other.gameObject.CompareTag("blueBox"))
            {
                buttonClick.PlayOneShot(buttonAudio);
            }
        }
        else if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("redBox"))
            {
                buttonClick.PlayOneShot(buttonAudio);
            }
           
        }

    }

    /*
    * @ pre none
    * @ param a 2d collider
    * @ post box puzzle: check two boxes are matched
    * @ return none
    */
    private void OnTriggerExit2D(Collider2D other)
    {
        buttonClick.pitch = 0.85F;        //button off click is pitched slightly lower
        
        if (gameObject.CompareTag("blueButton"))
        {
            if(other.gameObject.CompareTag("blueBox"))
            {
                anim.SetBool("isBlueButtonDown", false);
                blueButtonPressed = false;
                buttonClick.PlayOneShot(buttonAudio);

            }
        }
        else if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("redBox"))
            {
                anim.SetBool("isRedButtonDown", false);
                redButtonPressed = false;
                buttonClick.PlayOneShot(buttonAudio);

            }
           
        }
    }
}
