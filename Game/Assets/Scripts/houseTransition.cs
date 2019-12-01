using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class houseTransition : MonoBehaviour
{
    //make an array where you choose the size in the inspector, to hold all game objects
    //that we want to be destroyed upon transitioning to the next room

    public GameObject player;
    public objectVector playerLocation;
    private Camera camera;
    private static int index;    //used to move through the object vector array to change the camera's location as
    //the player moves between rooms
    //since the player can't go back anyway
    
    private void Start()
    {
        camera = Camera.main;
        index = 1;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            
            index = 0;    //update the index so that the camera's new boundaries are related to the town
            player.GetComponent<Transform>().position = playerLocation.initial;    //teleport player to next room
            camera.GetComponent<CameraMovement>().SetIndex(index);  //sets the camera's new boundary to next room's boundary

        }
    }
}