/**
KU EECS 448 project 3
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 enemyMovement.cs
  * \Date:   11/3/2019
  * \Brief:  This script makes enemy move towards you 
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    private Transform target;
    
    /*
     * @ pre none
     * @ param none
     * @ post get called before frame gets updated to make mob target player
     * @ return none
     */
    void Start() // Start is called before the first frame update
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post update every frame to make mob chase the target
     * @ return none
     */
    void Update() // Update is called once per frame
    {
        if (gameObject.GetComponent<enemyHealth>().isDead == true)
        {
            speed = 0;
        }
        
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
