using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    //private SpriteRenderer objectLayer;

   // private SpriteRenderer renderer = GetComponent<SpriteRenderer>();

    // Start is called before the first frame update
    void Start()
    {
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
        UpdateAnimationAndMove();
        
        // for checking collision with other objects

        //if(GameObject.Find("Player").transform.position.y > gameObject.transform.position.y)
        //{ 
        //    objectLayer.sortingOrder = 3;
        //}
        //else
        //{
        //   objectLayer.sortingOrder = 1;
        //}
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
        myRigidbody.MovePosition(
             transform.position + (Time.deltaTime * speed * change)
            );
    }
}
