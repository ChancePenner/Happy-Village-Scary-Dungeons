using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveData : MonoBehaviour
{
    public bool hasSword;

    public void playerData()
    {
        Debug.Log("CHECKING HAS SWORD");
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Debug.Log("TRANSFERRING SWORD");
            hasSword = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().ActiveSword();
            if (hasSword)
            {
                Debug.Log("it's legit");

            }
        }
//        GlobalControl.Instance.hasSword = hasSword;
    }

    public void moveInventory()
    {
        Debug.Log("GIVING SWORD");
        GlobalControl.hasSword = ApplicationData.hasSword;
        if (GlobalControl.hasSword)
        {
            Debug.Log("he has the sword");
        }
        GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().giveSword();
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().ActiveSword())
        {
            Debug.Log("BRO WTF");
        }
        


    }


}
