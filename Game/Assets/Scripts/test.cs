using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject Player; //default player

    // Start is called before the first frame update
    void Start()
    {
        test1();
        test2();
        test3();
        test4();
        test5();
    }

    private void test1() //test player does not have sword by default
    {
        Instantiate(Player);
        if (Player != null)
        {
            if (!Player.GetComponent<inventory>().ActiveSword())
            {
                Debug.Log(("Test player does not have sword by default: PASS\n"));
            }
            else
            {
                Debug.Log("Test player does not have sword by default: FAILED\n");
            }
        }
       Destroy(Player);
    }
    private void test2() //test player now has sword
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<inventory>().giveSword();
            if (Player.GetComponent<inventory>().ActiveSword())
            {
                Debug.Log(("Test player now has sword after giving it: PASS\n"));
            }
            else
            {
                Debug.Log("Test player now has sword after giving it: FAILED\n");
            }
            
        }
       Destroy(Player);
    }
    private void test3() //test player static inventory works
    {
        Instantiate(Player);
        if (Player != null)
        {
            if (Player.GetComponent<inventory>().ActiveSword())
            {
                Debug.Log(("Test player static inventory works: PASS\n"));
            }
            else
            {
                Debug.Log("Test player static inventory works: FAILED\n");
            }
            
        }
        Destroy(Player);
    }
    
    private void test4() //test player health after instantiating player health
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<playerHealth>().setHealth(3);
            if (Player.GetComponent<playerHealth>().getHealth() == 3)
            {
                Debug.Log(("Test player health after instantiating player health: PASS\n"));
            }
            else
            {
                Debug.Log("Test player health after instantiating player health: FAILED\n");
            }
            
        }
        Destroy(Player);
    }
    
    private void test5() //test player health is static
    {
        Instantiate(Player);
        if (Player != null)
        {
            if (Player.GetComponent<playerHealth>().getHealth() == 3)
            {
                Debug.Log(("Test player health is static: PASS\n"));
            }
            else
            {
                Debug.Log("Test player health is static: FAILED\n");
            }
            
        }
        Destroy(Player);
    }
}
