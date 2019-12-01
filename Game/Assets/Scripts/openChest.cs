/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 openChest.cs
  * \Date:   12/01/2019
*/

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
    
    /*
     * @ pre none
     * @ param none
     * @ post get called before frame gets updated and check the chest is able to open or not
     * @ return none
     */
    void Start() // Start is called before the first frame update
    {
        chestOpen = false;
        anim = GetComponent<Animator>();
    }
    
    /*
     * @ pre none
     * @ param a collider2D object
     * @ post if player collider intersect with other collider function got called and open a chest for player
     * @ return none
     */
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(tagName) && Input.GetKeyDown("space") && !chestOpen)
        {
            anim.SetBool("isOpened", true);
            chestIsOpen();
            Player = other;
        }
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post set the chest status to be opened
     * @ return none
     */
    private void chestIsOpen()
    {
        chestOpen = true;
      
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post spawn an enemy for player if chest is opened
     * @ return none
     */
    private void spawnEnemy()
    {
        Instantiate(Enemy);
    }

    /*
     * @ pre none
     * @ param none
     * @ post give player sword once chest is open
     * @ return none
     */
    private void giveSword()
    {
        if (Player != null)
        {
            Player.GetComponent<inventory>().giveSword();
        }
    }


}
