using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timescript : MonoBehaviour
{
    public GameObject timeTextObject;

    
    void Start()
    {
    InvokeRepeating("UpdateTime", 0f, 10f);   
    }

   
    void UpdateTime()
    {
    timeTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString("h:mm tt");
       
    }
}