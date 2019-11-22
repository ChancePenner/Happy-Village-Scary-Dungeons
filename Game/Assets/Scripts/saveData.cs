/**
KU EECS 448 project 3
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 saveData.cs
  * \Date:   11/3/2019
  * \Brief:  This script in charge of saving progress for player
 **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveData : MonoBehaviour
{
    public bool hasSword;
    public bool initLoad;

    /*
     * @ pre none
     * @ param none
     * @ post save player's status to global control object
     * @ return none
     */
    public void playerData()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            initLoad = false;
            
            hasSword = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().ActiveSword();
            GameObject.FindGameObjectWithTag("Player").GetComponent<initializeHealth>().initialLoad = initLoad;   //setting the load to false so town doesn't reinitialize the health
        }
    }

    /*
     * @ pre none
     * @ param none
     * @ post copy player's inventory from global object to next scene's player
     * @ return none
     */
    public void moveInventory()
    {
        GlobalControl.hasSword = ApplicationData.hasSword;
        GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().giveSword();
    }
}
