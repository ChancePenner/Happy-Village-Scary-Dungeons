/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 UpdateLayer.cs
  * \Date:   12/01/2019
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLayer : MonoBehaviour
{
    private SpriteRenderer objectLayer;

    /*
     * @ pre none
     * @ param none
     * @ post get called before frame gets updated
     * @ return none
     */
    void Start() // Start is called before the first frame update
    {
        objectLayer = GetComponent<SpriteRenderer>();
    }

    /*
     * @ pre none
     * @ param none
     * @ post change layer for player between 1 and 3
     * @ return none
     */
    void Update() // Update is called once per frame
    {
        if(GameObject.Find("Player").transform.position.y > gameObject.transform.position.y)
        { 
            objectLayer.sortingOrder = 3;
        }
        else
        {
            objectLayer.sortingOrder = 1;
        }
    }
}
