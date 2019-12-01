/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 initializeHealth.cs
  * \Date:   12/01/2019
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializeHealth : MonoBehaviour
{
    static bool initialLoad = true;

    /*
     * @ pre none
     * @ param none
     * @ post Start is called before the first frame update
     * @ return none
     */
    void Start()
    {

        if (initialLoad)
        {
            gameObject.GetComponent<playerHealth>().setHealth(12);
            gameObject.GetComponent<playerHealth>().setNumOfHearts(3);   
        }

        initialLoad = false;
    }

    /*
     * @ pre none
     * @ param none
     * @ post none
     * @ return initialLoad
     */
    public bool getInitialLoad()
    {
        return initialLoad;
    }
}

