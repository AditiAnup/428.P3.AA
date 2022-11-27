using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveALongPath : MonoBehaviour
{
    public Transform[] target;
    public GameObject selfObj;
    public float speed = 0.0f;
    private int current;
    private int counter=1;
    private int remainder = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position!=target[current].position)
        {
            transform.position= Vector3.MoveTowards(transform.position, target[current].position, speed*Time.deltaTime);
            //Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed*Time.deltaTime);
            //selfObj.MovePosition(pos);
        }
        else current = (current + 1) % target.Length;
    }
}
