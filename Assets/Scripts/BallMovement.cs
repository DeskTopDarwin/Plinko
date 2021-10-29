using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rg;
    private void Awake()
    {
        rg = gameObject.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && rg.isKinematic)
        {
            transform.position = transform.position + new Vector3(1 * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && rg.isKinematic)
        {
            transform.position = transform.position + new Vector3(-1 * Time.deltaTime, 0, 0);
        }
        
        //transform.position = transform.position + new Vector3(1, 0, 0);
    }
}
