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
    private GameObject Item;        //choosing which item the enemy
    private Collider2D  Player;
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

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(tagName) && Input.GetKeyDown("space") && !chestOpen)
        {
            anim.SetBool("isOpened", true);
            chestIsOpen();
            Player = other;
        }
    }

    private void chestIsOpen()
    {
        chestOpen = true;
      
    }

    private void spawnEnemy()
    { 
        if (Player != null)
        {
            Player.GetComponent<inventory>().giveSword();
        }
        Instantiate(Enemy);
    }

    private void giveItem()
    {
        
       // Instantiate(Item);
    }
    

}
