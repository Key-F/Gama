using UnityEngine;

public class BallControlCSharp : MonoBehaviour {

    public int speed = 500;
    public int sndspeed = 2000;
    public Rigidbody rb;
    public bool AddForce = false;

    void FixedUpdate()
    {   
        
        if (Input.GetKey("w"))
        {
            //AddForce == true ? rb.AddForce(0, sndspeed * Time.deltaTime, 0) : rb.velocity = Vector2.up * speed;
            if (AddForce)
                rb.AddForce(0, sndspeed * Time.deltaTime, 0);
            else
            rb.velocity = Vector2.up * speed;
        }
        if (Input.GetKey("a"))
        {
            if (AddForce)
                rb.AddForce(-sndspeed * Time.deltaTime, 0, 0);
            else
            rb.velocity = Vector2.left * speed;
        }
        if (Input.GetKey("d"))
        {
            if (AddForce)
                rb.AddForce(sndspeed * Time.deltaTime, 0, 0);
            else
            rb.velocity = Vector2.right * speed;
        }
        if (Input.GetKey("s"))
        {
            if (AddForce)
                rb.AddForce(0, -sndspeed * Time.deltaTime, 0);
            else
            rb.velocity = Vector2.down * speed;
        }
    }
       

       
}
