using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rg;

    public Transform leftWall;
    public Transform rightWall;
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
        Debug.Log("t: " + transform.position.x);
        Debug.Log("lw: " + leftWall.position.x);
        if (Input.GetKey(KeyCode.LeftArrow) && rg.isKinematic && transform.position.x < leftWall.position.x)
        {
            transform.position = transform.position + new Vector3(1 * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && rg.isKinematic && transform.position.x > rightWall.position.x)
        {
            transform.position = transform.position + new Vector3(-1 * Time.deltaTime, 0, 0);
        }
        
        else if (Input.GetKey(KeyCode.Space))
        {
            rg.isKinematic = false;
        }
        
        //transform.position = transform.position + new Vector3(1, 0, 0);
    }
}
