/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 inventory.cs
  * \Date:   12/01/2019
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    private static bool hasSword;
    private Animator animator;
    
    /*
     * @ pre none
     * @ param none
     * @ post get called before frame gets updated and check player has a sword or
     *   not and apply animation for a sword if player has sword
     * @ return none
     */
    void Start()  // Start is called before the first frame update
    {
        animator = GetComponent<Animator>();

        if (hasSword)
        {
            giveSword();
        }
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post gives player sword
     * @ return none
     */
    public void giveSword()
    {
        hasSword = true;
        if (animator != null)
        {
            animator.SetBool("hasSword", hasSword);
            ApplicationData.hasSword = hasSword;
        }
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post helper function to check player has a sword or not
     * @ return true if player has a sword, vice versa
     */
    public bool ActiveSword()
    {
        return hasSword;
    }
}


