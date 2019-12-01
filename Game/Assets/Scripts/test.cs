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
    // Start is called before the first frame update
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
//        test9();
//        test10();
    }

    private void test1() //test player does not have sword by default
    {
        Instantiate(Player);
        if (Player != null)
        {
            if (!Player.GetComponent<inventory>().ActiveSword())
            {
                result.text = "Test player does not have sword by default: PASS\n";
                Debug.Log(("Test player does not have sword by default: PASS\n"));
            }
            else
            {
                result.text = "Test player does not have sword by default: FAILED\n";
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
                result.text += "Test player now has sword after giving it: PASS\n";
                Debug.Log(("Test player now has sword after giving it: PASS\n"));
            }
            else
            {
                result.text += "Test player now has sword after giving it: FAILED\n";
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
                result.text += "Test player static inventory works: PASS\n";
                Debug.Log(("Test player static inventory works: PASS\n"));
            }
            else
            {
                result.text += "Test player static inventory works: FAILED\n";
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
            Player.GetComponent<playerHealth>().setHealth(12);
            if (Player.GetComponent<playerHealth>().getHealth() == 12)
            {
                result.text += "Test player health after instantiating player health: PASS\n";
                Debug.Log(("Test player health after instantiating player health: PASS\n"));
            }
            else
            {
                result.text += "Test player health after instantiating player health: FAILED\n";
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
            if (Player.GetComponent<playerHealth>().getHealth() == 12)
            {
                result.text += "Test player health is static: PASS\n";
                Debug.Log(("Test player health is static: PASS\n"));
            }
            else
            {
                result.text += "Test player health is static: FAILED\n";
                Debug.Log("Test player health is static: FAILED\n");
            }

        }
        Destroy(Player);
    }

    private void test6() //test player after taking damage
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<playerHealth>().harmPlayer(2);
            if (Player.GetComponent<playerHealth>().getHealth() == 10)
            {
                result.text += "Test player after taking damage: PASS\n";
                Debug.Log(("Test player after taking damage: PASS\n"));
            }
            else
            {
                result.text += "Test player after taking damage: FAILED\n";
                Debug.Log("Test player after taking damage: FAILED\n");
            }
        }
        Destroy(Player);
    }

    private void test7() //test player give health
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<playerHealth>().giveHealth(1);
            if (Player.GetComponent<playerHealth>().getHealth() == 11)
            {
                result.text += "Test player give health: PASS\n";
                Debug.Log(("Test player give health: PASS\n"));
            }
            else
            {
                result.text += "Test player give health: FAILED\n";
                Debug.Log("Test player give health: FAILED\n");
            }
        }
        Destroy(Player);
    }

//    private void test8() //test player after taking too much damage(Larger than your maximum amount)
//    {
//        Instantiate(Player);
//        if (Player != null)
//        {
//            Debug.Log(Player.GetComponent<playerHealth>().getHealth());
//            Player.GetComponent<playerHealth>().harmPlayer(12);
////            Task.Delay(5000).Wait();//wait until animation is done
//            Debug.Log(Player.GetComponent<playerHealth>().getHealth());
//            if (Player.GetComponent<playerHealth>().getHealth() == 0)
//            {
//                result.text += "Test player after taking too much damage: PASS\n";
//                Debug.Log(("Test player after taking too much damage: PASS\n"));
//            }
//            else
//            {
//                result.text += "Test player after taking too much damage: FAILED\n";
//                Debug.Log("Test player after taking too much damage: FAILED\n");
//            }
//        }
//        Destroy(Player);
//    }

    private void test8() //test player have correct number of hearts after initializing health
    {
        Instantiate(Player);
        if (Player != null)
        {
            Player.GetComponent<playerHealth>().setHealth(12);
            Player.GetComponent<playerHealth>().setNumOfHearts(3);
            if (Player.GetComponent<playerHealth>().getNumOfHearts() == 3 && Player.GetComponent<playerHealth>().getHealth() == 12)
            {
                result.text += "Test player have correct number of hearts after initializing health: PASS\n";
                Debug.Log(("Test player have correct number of hearts after initializing health: PASS\n"));
            }
            else
            {
                result.text += "Test player have correct number of hearts after initializing health: FAILED\n";
                Debug.Log("Test player have correct number of hearts after initializing health: FAILED\n");
            }
        }
        Destroy(Player);
    }

//    private void test10() //test trying to heal at full health
//    {
//        Instantiate(Player);
//        if (Player != null)
//        {
//            Player.GetComponent<playerHealth>().giveHealth(5);
//            if (Player.GetComponent<playerHealth>().getHealth() == 12)
//            {
//                result.text += "Test trying to heal at full health: PASS\n";
//                Debug.Log(("Test trying to heal at full health: PASS\n"));
//            }
//            else
//            {
//                result.text += "Test trying to heal at full health: FAILED\n";
//                Debug.Log("Test trying to heal at full health: FAILED\n");
//            }
//        }
//        Destroy(Player);
//    }


}
