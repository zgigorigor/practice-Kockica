using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000;
    public float sideForce = 500f;


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
    }
}
