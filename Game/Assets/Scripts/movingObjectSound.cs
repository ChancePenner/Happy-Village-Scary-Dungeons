/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 movingObjectSound.cs
  * \Date:   12/01/2019
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingObjectSound : MonoBehaviour
{
    public AudioSource buttonClick;
    public AudioClip[] buttonAudio;
    
    /*
     * @ pre none
     * @ param a 2d collider
     * @ post play moving sound 
     * @ return none
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        buttonClick.PlayOneShot(buttonAudio[2]);      
    }
    
    /*
    * @ pre none
    * @ param a 2d collider
    * @ post play moving sound
    * @ return none
    */
    private void OnCollisionExit2D(Collision2D other)
    {
        buttonClick.PlayOneShot(buttonAudio[2]);      
    }
    
}
