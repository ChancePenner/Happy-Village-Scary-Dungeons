using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLayer : MonoBehaviour
{
    private SpriteRenderer objectLayer;

    // Start is called before the first frame update
    void Start()
    {
        objectLayer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player").transform.position.y > gameObject.transform.position.y)
        { 
            objectLayer.sortingOrder = 3;
        }
        else
        {
            objectLayer.sortingOrder = 1;
        }
    }
}
