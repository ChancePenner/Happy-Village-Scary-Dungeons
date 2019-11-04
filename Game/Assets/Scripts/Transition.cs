/**
KU EECS 448 project 3
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 Transition.cs
  * \Date:   11/3/2019
  * \Brief:  This script in charge of scene transition function
 **/

using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public string loadScene;
    public Vector2 playerLocation;
    public objectVector playerTemp;
    public GameObject player;
    public saveData playerSave; 
    
    /*
     * @ pre none
     * @ param a collider2D object
     * @ post if player collider intersect with other collider function got called and load the next scene
     * @ return none
     */
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            Debug.Log("TRANSITIONING!");
            playerSave = new saveData();
            playerSave.playerData();
            playerTemp.initial = playerLocation;
            SceneManager.LoadScene(loadScene);
//            SceneManager.SetActiveScene(SceneManager.GetSceneByName(loadScene));
            playerSave.moveInventory();
        }
    }
}