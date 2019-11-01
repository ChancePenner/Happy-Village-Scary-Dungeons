using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private Vector3 change;
    private Animator animator;
    //private SpriteRenderer objectLayer;

   // private SpriteRenderer renderer = GetComponent<SpriteRenderer>();

    // Start is called before the first frame update
    void Start()
    {
        currentState = PlayerState.walk;
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        //objectLayer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("attack") && currentState != PlayerState.attack)
        {
            StartCoroutine(AttackCo());    
        }
        if (currentState == PlayerState.walk)
        {
            UpdateAnimationAndMove();
        }
        //UpdateAnimationAndMove();
    }
    
    private IEnumerator AttackCo()        //runs in parallel to something
    {
        animator.SetBool("attacking", true);      //setting animation bool to true
        currentState = PlayerState.attack;
        yield return null;                                    //waits 1 frame
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);                 //waits .3 seconds 
        currentState = PlayerState.walk;
    }

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

    void MoveCharacter()
    {
        change.Normalize();
        myRigidbody.MovePosition(
             transform.position + (Time.deltaTime * speed * change)
            );
    }
}
