using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveHealth : MonoBehaviour
{
    private int health;
    private int numOfHearts;
    public void OnTriggerEnter2D(Collider2D other)
    {
        health = other.gameObject.GetComponent<playerHealth>().getHealth();
        numOfHearts = other.gameObject.GetComponent<playerHealth>().getNumOfHearts();
        
        if (other.CompareTag("Player"))
        {
            //Debug.Log(health);
            health += 4;

            other.gameObject.GetComponent<playerHealth>().setHealth(health);
            other.gameObject.GetComponent<playerHealth>().setNumOfHearts(numOfHearts);
        }

        Destroy(gameObject);        //destroy the heart
    }
    
}
