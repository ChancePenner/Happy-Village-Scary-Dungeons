using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    private static bool hasSword;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        if (hasSword)
        {
            giveSword();
        }
    }

    public void giveSword()
    {
        hasSword = true;
        if (animator != null)
        {
            animator.SetBool("hasSword", hasSword);
            ApplicationData.hasSword = hasSword;
        }
    }

    public bool ActiveSword()
    {
        return hasSword;
    }
}


