using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{

    public string tagName;
    public GameObject[] objects;
    private bool chestOpen;
    private Animator anim; 
    
    // Start is called before the first frame update
    void Start()
    {
        chestOpen = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(tagName) && !chestOpen)
        {
            chestOpen = true;
            anim.SetBool("isOpened", true);
        }
    }

}
