using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallControlCSharp : MonoBehaviour {

    public int speed = 500;
    public Rigidbody rb;

    void FixedUpdate()
    {      
        if (Input.GetKey("w"))
        {
            //rb.AddForce(0, speed * Time.deltaTime, 0);
            rb.velocity = Vector2.up * speed;
        }
        if (Input.GetKey("a"))
        {
            //rb.AddForce(-speed * Time.deltaTime, 0, 0);
            rb.velocity = Vector2.left * speed;
        }
        if (Input.GetKey("d"))
        {
            //rb.AddForce(speed * Time.deltaTime, 0, 0);
            rb.velocity = Vector2.right * speed;
        }
        if (Input.GetKey("s"))
        {
            //rb.AddForce(0, -speed * Time.deltaTime, 0);
            rb.velocity = Vector2.down * speed;
        }
    }
       

       
}
