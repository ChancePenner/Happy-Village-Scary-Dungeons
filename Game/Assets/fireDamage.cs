using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireDamage : MonoBehaviour
{
    public int fireStrength;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<playerHealth>().harmPlayer(fireStrength);
        }
    }

    private void disableCollision()
    {
        GetComponent<Collider2D>().enabled = false;
    }
    
    private void enableCollision()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
