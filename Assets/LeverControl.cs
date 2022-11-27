using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class LeverControl : MonoBehaviour
{
    public Transform LeverTop;
    [SerializeField]
    private float forwardTilt=0;
    public Transform Spawnpoint;
    public GameObject G;
    public bool isSpawned;
    private GameObject newObject;
    // Start is called before the first frame update
    void Start()
    {
        isSpawned=false;
    }

    public void Control()
        {
            isSpawned=true;
            Instantiate(G, Spawnpoint.position, Quaternion.Euler(0,0,0));
            isSpawned=false;
        }
    
}
