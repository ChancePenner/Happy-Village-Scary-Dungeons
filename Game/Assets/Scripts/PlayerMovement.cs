/**
KU EECS 448 project 3
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 PlayerMovement.cs
  * \Date:   11/3/2019
  * \Brief:  This script in charge of player's movement and position
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public enum PlayerState
{
    walk,
    attack,
    interact
}

public class PlayerMovement : MonoBehaviour
{
    public PlayerState currentState;
    public float speed;
    private Rigidbody2D myRigidbody;
    //private GameObject Player;
    private Vector3 change;
    private Animator animator;
    public objectVector startPosition;
    
    /**
     ** @ pre none
     ** @ param none
     ** @ post gets called before frame gets updated and preset player's states to be walk
     ** @ return none
     **/
    void Start() // Start is called before the first frame update
    {
        currentState = PlayerState.walk;
        //Player = gameObject;
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        animator.SetFloat("Horizontal", 0);    //fixes idleDown attack activating all sword collisions 
        animator.SetFloat("Vertical", -1);     //these initialize idle down to 0,-1 since we are facing downward
                                                            //setting animator values of idle down of player 
        transform.position = startPosition.initial;
    }
    
    /**
     ** @ pre none
     ** @ param none
     ** @ post update every frame to make sure player can have movement each frame
     ** @ return none
     **/
    void Update() // Update is called once per frame
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("attack") && currentState != PlayerState.attack && gameObject.GetComponent<inventory>().ActiveSword())
        {
            StartCoroutine(AttackCo());    
        }
        if (currentState == PlayerState.walk)
        {
            UpdateAnimationAndMove();
        }
        //UpdateAnimationAndMove();
    }
    
    /**
     ** @ pre none
     ** @ param none
     ** @ post let player attack if player has sword
     ** @ return none
     **/
    private IEnumerator AttackCo()        //runs in parallel to something
    {
        animator.SetBool("attacking", true);      //setting animation bool to true
        currentState = PlayerState.attack;
        yield return null;                                    //waits 1 frame
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);                 //waits .3 seconds 
        currentState = PlayerState.walk;
    }
    
    /**
     ** @ pre none
     ** @ param none
     ** @ post player player's animation
     ** @ return none
     **/
    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero) //if there actually is a change happening
        {
            MoveCharacter();
            animator.SetFloat("Horizontal", change.x);
            animator.SetFloat("Vertical", change.y);
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }
    }
    
    /**
     * @ pre none
     * @ param none
     * @ post let player move as input demands
     * @ return none
     */
    void MoveCharacter()
    {
        change.Normalize();
        myRigidbody.MovePosition(
             transform.position + (Time.deltaTime * speed * change)
            );
    }
}
