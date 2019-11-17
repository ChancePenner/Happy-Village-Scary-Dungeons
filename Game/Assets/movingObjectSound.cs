using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingObjectSound : MonoBehaviour
{
    public AudioSource buttonClick;
    public AudioClip[] buttonAudio;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        buttonClick.PlayOneShot(buttonAudio[2]);      
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        buttonClick.PlayOneShot(buttonAudio[2]);      
    }
    
}
