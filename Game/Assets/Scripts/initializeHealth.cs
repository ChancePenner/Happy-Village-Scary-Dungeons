using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializeHealth : MonoBehaviour
{
    static bool initialLoad = true;
    // Start is called before the first frame update
    void Start()
    {

        if (initialLoad)
        {
            gameObject.GetComponent<playerHealth>().setHealth(12);
            gameObject.GetComponent<playerHealth>().setNumOfHearts(3);   
        }

        initialLoad = false;
    }

    public bool getInitialLoad()
    {
        return initialLoad;
    }
}

