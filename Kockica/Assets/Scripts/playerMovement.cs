using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    //public float forwardForce = 1000;
    //public float sideForce = 2500;
    private float forwardForce;
    private float sideForce;

    void Start()
    {
        forwardForce = FindObjectOfType<GameManager>().speed;
        sideForce = FindObjectOfType<GameManager>().force;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow) )
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }

        if( Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow) )
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }

        if ( rb.position.y < - 0.7 )
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}