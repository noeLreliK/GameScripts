using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;
    void OnTriggerEnter(Collider often)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;  
    }
    void OnTriggerEnter(ColLider often)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
