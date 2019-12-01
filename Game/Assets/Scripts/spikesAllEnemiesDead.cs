/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 spikeAllEnemiesDead.cs
  * \Date:   12/01/2019
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikesAllEnemiesDead : MonoBehaviour
{
    private int numEnemies;
    private GameObject[] enemies;
    private bool enemySpawned;
    private Animator animator;
    public GameObject player;

    /*
     * @ pre none
     * @ param none
     * @ post get called before frame update and check number of mobs in the scene
     * @ return none
     */
    void Start()
    {
        animator = GetComponent<Animator>();
        numEnemies = 0;
        enemySpawned = false;
    }

    /*
     * @ pre none
     * @ param none
     * @ post get called every frame to check if there is any mob in the scene
     * @ return none
     */
    void Update() // Update is called once per frame
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy"); //MAKE SURE TO TAG ENEMY AS "ENEMY"
        
        if (enemies.Length > 0)
        {
            enemySpawned = true;
        }

        if (enemySpawned)
        {
            if (enemies.Length == 0)        //at this point all enemies are dead
            {
                animator.SetBool("allEnemiesDead",true);
                Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), animator.GetComponent<Collider2D>());
            }
        }
    }

}
