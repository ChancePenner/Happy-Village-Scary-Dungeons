/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 dropItem.cs
  * \Date:   12/01/2019
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public SpriteRenderer item;

    /*
     * @ pre none
     * @ param none
     * @ post drop an item to desired location
     * @ return none
     */
    void itemDrop()
    {
        Instantiate(item, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
