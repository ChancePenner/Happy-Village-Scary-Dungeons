/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 RoomTransition.cs
  * \Date:   12/01/2019
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class RoomTransition : MonoBehaviour
{
    //make an array where you choose the size in the inspector, to hold all game objects
    //that we want to be destroyed upon transitioning to the next room

    public GameObject player;
    public objectVector playerLocation;
    private Camera camera;
    private static int index;    //used to move through the object vector array to change the camera's location as
                          //the player moves between rooms
    public GameObject GameObjectsToDestroy;    //holds the game objects we want to destroy once player leaves that room
                                                 //since the player can't go back anyway
    
                                                 /*
     * @ pre none
     * @ param none
     * @ post start get called when script is triggered
     * @ return none
     */
    private void Start()
    {
        camera = Camera.main;
        index = 0;
    }

    /*
     * @ pre none
     * @ param a 2d collider
     * @ post teleport player to next room
     * @ return none
     */
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            index++;    //update the index so that the camera's new boundaries are related to the next room
            player.GetComponent<Transform>().position = playerLocation.initial;    //teleport player to next room
            camera.GetComponent<CameraMovement>().SetIndex(index);  //sets the camera's new boundary to next room's boundary

            Destroy(GameObjectsToDestroy);
        }
    }
}
