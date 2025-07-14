using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Colider other){
        other.GetComponent<Jump>().jumpStrength = 10;
    }
    void OnTriggerExit(Colider other){
        other.GetComponent<Jump>().jumpStrength = 2;
    }
    
  
}
