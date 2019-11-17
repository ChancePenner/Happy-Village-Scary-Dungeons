using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRoom : MonoBehaviour
{
    public GameObject[] enemies;        //game object array for the enemies in the room
    public GameObject nextRoomTransition;
        
    private void OnTriggerEnter2D(Collider2D other) //trigger for the player entering the new room 
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
