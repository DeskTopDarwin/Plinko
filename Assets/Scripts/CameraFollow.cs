using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform objectToFollow;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = transform.position;
        //camPos
        camPos.x = objectToFollow.position.x;
        camPos.y = objectToFollow.position.y;
        transform.position = camPos;
           
       
    }
}
