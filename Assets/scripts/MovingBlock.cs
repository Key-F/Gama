using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour {

    public Rigidbody rb;
    public float speed = 10;
    bool goUp = true;
    public float toppoint = 12;
    public float botpoint = 3;
    public float rightpoint = 8;
    public float leftpoint = 4;
    public Vector3 firstdir = new Vector3(1, 0, 0);
    public Vector3 secondtdir = new Vector3(-1, 0, 0);
    public bool horizontal = true;

    void FixedUpdate () {
        if (goUp)
        {
            transform.Translate(firstdir * speed * Time.fixedDeltaTime);
            if ((!horizontal) && (transform.position.y > toppoint) || (transform.position.x > rightpoint))
            {
                goUp = false;
                return;
            }
        }
        if (!goUp)
        {
            transform.Translate(secondtdir * speed * Time.fixedDeltaTime);
            if ((!horizontal) && (transform.position.y < botpoint) || (transform.position.x < leftpoint))
            {
                goUp = true;
                return;
            }

        }
    }
}
