/**
KU EECS 448 project 3
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 CameraMovement.cs
  * \Date:   11/3/2019
  * \Brief:  This script in charge of main camera auto following character
 **/

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothingSpeed;
    public objectVector[] maxPosition;
    public objectVector[] minPosition;
    private int index;    //used to move through the object vector array to change the camera's location as
                          //the player moves between rooms

    private void Start()
    {
        index = 0;    //initialize to 0
    }

    /*
     * @ pre none
     * @ param none
     * @ post  every frame this function get called to stick camera with player
     * @ return none
     */
    void LateUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x,
                target.position.y,
                transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x,
                                                minPosition[index].initial.x,
                                                maxPosition[index].initial.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y,
                                                minPosition[index].initial.y,
                                                maxPosition[index].initial.y);
            transform.position = Vector3.Lerp(transform.position,
                targetPosition,
                smoothingSpeed);
        }
    }

    public void SetIndex(int newIndex)
    {
        index = newIndex;
    }
}