using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializeHealth : MonoBehaviour
{
    public bool initialLoad;
    // Start is called before the first frame update
    void Start()
    {
        initialLoad = true;
        //initialLoad = gameObject.GetComponent<saveData>().initLoad;
        
        if (initialLoad == true)
        {
            gameObject.GetComponent<playerHealth>().setHealth(12);
            gameObject.GetComponent<playerHealth>().setNumOfHearts(3);   
        }
    }

    public bool getInitialLoad()
    {
        return initialLoad;
    }
}

