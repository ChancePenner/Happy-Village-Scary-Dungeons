/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 portal.cs
  * \Date:   12/01/2019
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public objectVector teleportLocation;
    
    /*
     * @ pre none
     * @ param a 2d collider
     * @ post teleport the player to the place by desire
     * @ return none
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other != null)
        {
            other.gameObject.GetComponent<Transform>().position = teleportLocation.initial;    //teleport player to next room
        }
    }
}
