using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverscript : MonoBehaviour
{
    public GameObject intIcon, lighton, lightoff, switchOn, SwitchOff;
    public bool toggle;
    void OnTriggerStay(Collider other) 
    {
        if(other.CompareTag("MainCamera"))
        {
            intIcon.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(toggle == true)
                {
                    lighton.SetActive(true);
                    lightoff.SetActive(false);
                    switchOn.SetActive(true);
                    SwitchOff.SetActive(false);
                }

                if(toggle == false)
                {
                    lighton.SetActive(false);
                    lightoff.SetActive(true);
                    switchOn.SetActive(false);
                    SwitchOff.SetActive(true);
                }
            }
        }   
    }

    void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("MainCamera"))
        {
            intIcon.SetActive(false);
        } 
    }
}
