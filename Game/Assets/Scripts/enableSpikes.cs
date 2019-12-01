/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 enableSpikes.cs
  * \Date:   12/01/2019
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableSpikes : MonoBehaviour
{
    public GameObject player;
    public Animator spike1;
    public Animator spike2;

    /*
     * @ pre none
     * @ param a 2d collider
     * @ post enable the spike when two collider intersects
     * @ return none
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spike1.SetBool("spawningEnemies", true);
            spike2.SetBool("spawningEnemies", true);
        }
    }
   
}
