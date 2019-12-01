/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 test.cs
  * \Date:   12/01/2019
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public GameObject Player; //default player

    public Text result;
    void Start()
    {
        result = GetComponent<Text>();
        test1();
        test2();
        test3();
        test4();
        test5();
        test6();
        test7();
        test8();
    }

    /*
     * @ pre none
     * @ param none
     * @ post test player does not have sword by default
     * @ return none
     */
    private void test1() 
    {
        Instantiate(Player);
        if (Player != null)
        {
            if (!Player.GetComponent<inventory>().ActiveSword())
            {
                result.text = "Test player does not have sword by default: PASS\n";
//                Debug.Log(("Test player does not have sword by default: PASS\n"));
            }
            else
            {
                result.text = "Test player does not have sword by default: FAILED\n";
//                Debug.Log("Test player does not have sword by default: FAILED\n");
            }
        }
       Destroy(Player);
    }
    /*
     * @ pre none
     * @ param none
     * @ post test player now has sword
     * @ return none
     */
    private void test2() 
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<inventory>().giveSword();
            if (Player.GetComponent<inventory>().ActiveSword())
            {
                result.text += "Test player now has sword after giving it: PASS\n";
//                Debug.Log(("Test player now has sword after giving it: PASS\n"));
            }
            else
            {
                result.text += "Test player now has sword after giving it: FAILED\n";
//                Debug.Log("Test player now has sword after giving it: FAILED\n");
            }

        }
       Destroy(Player);
    }
    /*
     * @ pre none
     * @ param none
     * @ post test player static inventory works
     * @ return none
     */
    private void test3()
    {
        Instantiate(Player);
        if (Player != null)
        {
            if (Player.GetComponent<inventory>().ActiveSword())
            {
                result.text += "Test player static inventory works: PASS\n";
//                Debug.Log(("Test player static inventory works: PASS\n"));
            }
            else
            {
                result.text += "Test player static inventory works: FAILED\n";
//                Debug.Log("Test player static inventory works: FAILED\n");
            }

        }
        Destroy(Player);
    }

    /*
     * @ pre none
     * @ param none
     * @ post test player health after instantiating player health
     * @ return none
     */
    private void test4() 
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<playerHealth>().setHealth(12);
            if (Player.GetComponent<playerHealth>().getHealth() == 12)
            {
                result.text += "Test player health after instantiating player health: PASS\n";
//                Debug.Log(("Test player health after instantiating player health: PASS\n"));
            }
            else
            {
                result.text += "Test player health after instantiating player health: FAILED\n";
//                Debug.Log("Test player health after instantiating player health: FAILED\n");
            }

        }
        Destroy(Player);
    }

    /*
     * @ pre none
     * @ param none
     * @ post test player health is static
     * @ return none
     */
    private void test5()
    {
        Instantiate(Player);
        if (Player != null)
        {
            if (Player.GetComponent<playerHealth>().getHealth() == 12)
            {
                result.text += "Test player health is static: PASS\n";
//                Debug.Log(("Test player health is static: PASS\n"));
            }
            else
            {
                result.text += "Test player health is static: FAILED\n";
//                Debug.Log("Test player health is static: FAILED\n");
            }

        }
        Destroy(Player);
    }

    /*
     * @ pre none
     * @ param none
     * @ post test player after taking damage
     * @ return none
     */
    private void test6()
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<playerHealth>().harmPlayer(2);
            if (Player.GetComponent<playerHealth>().getHealth() == 10)
            {
                result.text += "Test player after taking damage: PASS\n";
//                Debug.Log(("Test player after taking damage: PASS\n"));
            }
            else
            {
                result.text += "Test player after taking damage: FAILED\n";
//                Debug.Log("Test player after taking damage: FAILED\n");
            }
        }
        Destroy(Player);
    }

    /*
     * @ pre none
     * @ param none
     * @ post test player give health
     * @ return none
     */
    private void test7()
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<playerHealth>().giveHealth(1);
            if (Player.GetComponent<playerHealth>().getHealth() == 11)
            {
                result.text += "Test player give health: PASS\n";
//                Debug.Log(("Test player give health: PASS\n"));
            }
            else
            {
                result.text += "Test player give health: FAILED\n";
//                Debug.Log("Test player give health: FAILED\n");
            }
        }
        Destroy(Player);
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post test player have correct number of hearts after initializing health
     * @ return none
     */
    private void test8()
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<playerHealth>().setHealth(12);
            Player.GetComponent<playerHealth>().setNumOfHearts(3);
            if (Player.GetComponent<playerHealth>().getNumOfHearts() == 3 && Player.GetComponent<playerHealth>().getHealth() == 12)
            {
                result.text += "Test player have correct number of hearts after initializing health: PASS\n";
//                Debug.Log(("Test player have correct number of hearts after initializing health: PASS\n"));
            }
            else
            {
                result.text += "Test player have correct number of hearts after initializing health: FAILED\n";
//                Debug.Log("Test player have correct number of hearts after initializing health: FAILED\n");
            }
        }
        Destroy(Player);
    }
    
}
