using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    private bool hasSword;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        hasSword = false;
        animator = GetComponent<Animator>();
    }

    public void giveSword()
    {
        hasSword = true;
        if (animator != null)
        {
            animator.SetBool("hasSword", hasSword);
        }
    }

   
 }
