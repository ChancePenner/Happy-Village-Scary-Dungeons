using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableSpikes : MonoBehaviour
{
    public GameObject player;
    public Animator spike1;
    public Animator spike2;

    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spike1.SetBool("spawningEnemies", true);
            spike2.SetBool("spawningEnemies", true);
        }
    }
   
}
