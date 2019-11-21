using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public SpriteRenderer item;

    void itemDrop()
    {
        Instantiate(item, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
