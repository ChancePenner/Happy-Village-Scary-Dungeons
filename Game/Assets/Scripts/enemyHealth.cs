using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class enemyHealth : MonoBehaviour
{

    public double enemy_health;
    public bool isDead; 
    private Rigidbody2D myRigidbody;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        enemy_health = 4.0;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy_health <= 0.0)
        {
            isDead = true;
            animator.SetBool("enemyDead", isDead);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("swordHitbox") && enemy_health > 0.0)
        {
            enemy_health -= 1.0;
            Debug.Log(enemy_health);

            Vector2 difference = transform.position - other.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x, transform.position.y + difference.y);
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Vector2 difference = other.transform.position - transform.position;
            other.transform.position = new Vector2(other.transform.position.x + difference.x, other.transform.position.y + difference.y);
        }
    }


    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
    
    
    
}
