/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 nextRoom.cs
  * \Date:   12/01/2019
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRoom : MonoBehaviour
{
    public GameObject[] enemies;        //game object array for the enemies in the room
    public GameObject nextRoomTransition;
     
    /*
   * @ pre none
   * @ param a 2d collider
   * @ post trigger for the player entering the new room 
   * @ return none
   */
    private void OnTriggerEnter2D(Collider2D other) 
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
            {
                enemies[i].SetActive(true);
            }
        }
    }
}
