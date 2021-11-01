using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rg;
    public float offset;
    public float speed;
    public Transform leftWall;
    public Transform rightWall;

   
    private Transform initialTransform;
    private bool isGameOver = false;

    private void Awake()
    {
        rg = gameObject.GetComponent<Rigidbody>();
        initialTransform = transform;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("t: " + transform.position.x);
        //Debug.Log("lw: " + leftWall.position.x);
        if (Input.GetKey(KeyCode.LeftArrow) && rg.isKinematic && transform.position.x < leftWall.position.x - offset)
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && rg.isKinematic && transform.position.x > rightWall.position.x + offset)
        {
            transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        
        else if (Input.GetKey(KeyCode.Space))
        {
            rg.isKinematic = false;
        }

        else if (Input.anyKeyDown && isGameOver)
        {
            transform.position = initialTransform.position;
            isGameOver = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        string win = "win";
        string lose = "lose";

        if (other.CompareTag(win))
        {
            Debug.Log("win");
            isGameOver = true;
        }
        else if(other.CompareTag(lose))
        {
            Debug.Log("lose");
            isGameOver = true;
        }
    }
}
