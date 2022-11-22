using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject G;
    public bool isSpawned;
    // Start is called before the first frame update
    void Start()
    {
        isSpawned=false;
    }

    // Update is called once per frame
    public void SpawnDonut()
    {
        if(!isSpawned)
        {
            isSpawned=true;
            Instantiate(G, Spawnpoint.position, Spawnpoint.rotation);
            isSpawned=false;
        }
    }
}
