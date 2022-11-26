using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradSwitch : MonoBehaviour
{
    public GameObject G;
    public GameObject newObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SwitchMode()
    {
        //yield return new WaitForSeconds(10);

        if(G.activeInHierarchy)
        {
            G.SetActive(false);
            newObject.SetActive(true);
        }
        else
        {
            G.SetActive(true);
            newObject.SetActive(false);
        }

        
    }
}
