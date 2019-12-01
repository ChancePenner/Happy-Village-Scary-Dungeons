/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 spikeDamage.cs
  * \Date:   12/01/2019
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class spikeDamage : MonoBehaviour
{
    public int spikeStrength;
    
    /*
     * @ pre none
     * @ param a 2d collider
     * @ post damage player
     * @ return none
     */
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<playerHealth>().harmPlayer(spikeStrength);
        }
    }

    /*
     * @ pre none
     * @ param none
     * @ post disable spike collision
     * @ return none
     */
    private void disableCollision()
    {
        GetComponent<Collider2D>().enabled = false;
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post enable spike collision
     * @ return none
     */
    private void enableCollision()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
