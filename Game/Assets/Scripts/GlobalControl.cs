/**
KU EECS 448 project 3
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 GlobalControl.cs
  * \Date:   11/3/2019
  * \Brief:  This script keep global control object from being destroyed when scene is loaded
 **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;
    public static bool hasSword;
    
    /*
     * @ pre none
     * @ param none
     * @ post keep global control object from being destroyed when scene is loaded
     * @ return none
     */
    void Awake ()   
    {
        if (Instance == null)
        {
            Debug.Log("DONT DESTROY!");
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
    }
    
}
