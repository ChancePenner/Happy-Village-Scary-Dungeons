/**
KU EECS 448 project 3
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 UpdateLayerTilemap.cs
  * \Date:   11/3/2019
  * \Brief:  This script in charge of tilemap layer
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class UpdateLayerTilemap : MonoBehaviour
{
    private TilemapRenderer objectLayer;

    /*
     * @ pre none
     * @ param none
     * @ post gets called before frame gets updated and get tilemap component 
     * @ return none
     */
    void Start() // Start is called before the first frame update
    {
        objectLayer = GetComponent<TilemapRenderer>();
    }

    /*
     * @ pre none
     * @ param none
     * @ post update every frame and set player layer between 1 and 3
     * @ return none
     */
    void Update() // Update is called once per frame
    {
        if(GameObject.Find("Player").transform.position.y > gameObject.transform.position.y)
        {
            objectLayer.sortingOrder = 1;
        }
        else
        {
            objectLayer.sortingOrder = 3;
        }
    }
}