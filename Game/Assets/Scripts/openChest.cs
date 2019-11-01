using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{

    public string tagName;
    public GameObject[] objects;
    public GameObject Enemy;
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
           
            anim.SetBool("isOpened", true);
            chestIsOpen();
        }
    }

    private void chestIsOpen()
    {
        Debug.Log("chest getting called!");
        chestOpen = true;
    }

    private void spawnEnemy()
    {
        Instantiate(Enemy);
    }
    

}
