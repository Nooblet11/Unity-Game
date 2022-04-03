using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playermovement : MonoBehaviour
{
    [SerializeField] float controlspeed = 10f;
    [SerializeField] float xRange = 10f;
    float yThrow;
    float xThrow;
    [SerializeField] float positionYawFactor = 2f;
    double stopMovement;
    GameObject getStopMovement;
    float stop;


    void Update()
    {
        if (stop < 35.87f)
        {
            ProcessMovement();
            ProcessRotation();
            getStopMovement = GameObject.Find("Player rig");
            stop = getStopMovement.transform.position.x;
           // GetComponent<Animator>().SetTrigger("Exit");
        }
        else
        {

        }
        
    }

    void ProcessRotation()
    {
        float pitch = 0f;
        float roll = 0f;
        float yaw = transform.localPosition.x * positionYawFactor;
        transform.localRotation = Quaternion.Euler(pitch,yaw,roll);

    }

    void ProcessMovement()
    {

        yThrow = Input.GetAxis("Vertical");
        xThrow = Input.GetAxis("Horizontal");

        float xOffset = xThrow * Time.deltaTime * controlspeed;
        float newXPos = transform.localPosition.x + xOffset;
        float clampXPos = Mathf.Clamp(newXPos, -xRange, xRange);

        transform.localPosition = new Vector3(newXPos, transform.localPosition.y, transform.localPosition.z);
    }
}
    