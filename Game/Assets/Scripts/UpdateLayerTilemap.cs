using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class UpdateLayerTilemap : MonoBehaviour
{
    private TilemapRenderer objectLayer;

    // Start is called before the first frame update
    void Start()
    {
        objectLayer = GetComponent<TilemapRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player").transform.position.y > gameObject.transform.position.y)
        {
            objectLayer.sortingOrder = 1;
        }
        else
        {
            objectLayer.sortingOrder = 3;
        }
    }
}