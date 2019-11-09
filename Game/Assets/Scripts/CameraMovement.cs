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
using UnityEditor;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothingSpeed;
    public Vector2 maxPosition;
    public Vector2 minPosition;

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
                                                minPosition.x,
                                                maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y,
                                                minPosition.y,
                                                maxPosition.y);
            transform.position = Vector3.Lerp(transform.position,
                targetPosition,
                smoothingSpeed);
        }
    }
}