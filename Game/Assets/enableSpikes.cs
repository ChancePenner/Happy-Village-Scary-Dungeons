using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableSpikes : MonoBehaviour
{
    public GameObject player;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == player)
        {
            animator.SetBool("spawningEnemies", true);
        }
    }
   
}
