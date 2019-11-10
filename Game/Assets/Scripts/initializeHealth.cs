using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializeHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<playerHealth>().setHealth(12);
        gameObject.GetComponent<playerHealth>().setNumOfHearts(3);
    }
    
}
