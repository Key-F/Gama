using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour {

    public Rigidbody rb;
    public float speed = 10;
    bool goUp = true;
    public float toppoint = 12;
    public float botpoint = 3;

    void FixedUpdate () {
        
        if (goUp)
        {
            transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
            if (transform.position.y > toppoint)
            {
                goUp = false;
                return;
            }
        }
        if (!goUp)
        {
            transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);
            if (transform.position.y < botpoint)
            {
                goUp = true;
                return;
            }

        }
    }
}
