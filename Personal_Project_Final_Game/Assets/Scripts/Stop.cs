using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public float stopMovement;
    // Update is called once per frame
    void Update()
    {
        stopMovement = gameObject.transform.position.x;
    }
}
