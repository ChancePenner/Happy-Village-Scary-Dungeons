/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 Exit.cs
  * \Date:   12/01/2019
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    /*
     * @ pre none
     * @ param none
     * @ post exit the application
     * @ return none
     */
    public void exitGame()
    {
//    Debug.Log("Exiting game");
        Application.Quit();
    }
}
