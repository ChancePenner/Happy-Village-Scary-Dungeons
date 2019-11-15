using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRoom : MonoBehaviour
{
    public GameObject[] enemies;
    //somehow do if player gets moved to the new object vector,
    //can we compare the player's current location to the location of this object vector??

    private void OnTriggerEnter2D(Collider2D other) //trigger for the player entering the new room 
    {
        Debug.Log("Hit next room trigger");

        Instantiate(enemies[0], new Vector3(0, 44.3f, 0), Quaternion.identity); //bat 1
        Instantiate(enemies[1], new Vector3(-2.5f, 45.3f, 0), Quaternion.identity); //bat 2
        Instantiate(enemies[2], new Vector3(2.5f, 45.3f, 0), Quaternion.identity); //bat 3
        GetComponent<Collider2D>().enabled = false;    //disable the trigger so the enemies cannot spawn again
    }
}
