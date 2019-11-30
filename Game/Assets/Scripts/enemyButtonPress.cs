using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class enemyButtonPress : MonoBehaviour
{
    
    private static bool buttonPressed;
    private Animator anim;
    private Animator doorAnim;
    public AudioSource buttonClick;
    public AudioClip buttonAudio;
    public GameObject player;

    public GameObject door;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        doorAnim = door.GetComponent<Animator>();
        buttonPressed = false;
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy1"))
            {
               anim.SetBool("isRedButtonDown", true);
               buttonPressed = true;
            }
         

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        buttonClick.pitch = 1;        //button on pitch is normal pitch of audio clips
        
        if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("Enemy1"))    //once enemy steps on button...
            {
                doorAnim.SetBool("allEnemiesDead", true);    //opens the door
                Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), door.GetComponent<Collider2D>());    //ignores the door collision so player can pass through
                buttonClick.PlayOneShot(buttonAudio);    //plays button sound
            }
           
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        buttonClick.pitch = 0.85F;        //button off click is pitched slightly lower
        
       
        if (gameObject.CompareTag("redButton"))
        {
            if(other.gameObject.CompareTag("Enemy1"))    //once enemy steps off button
            {
                anim.SetBool("isRedButtonDown", false);
                buttonPressed = false;
                buttonClick.PlayOneShot(buttonAudio);

            }
           
        }
    }
}
