using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour {

    public Rigidbody rb;
    public float speed = 10;
    bool goUp = true;

    void Update () {
        
        if (goUp)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.y > 12)
            {
                goUp = false;
                return;
            }
        }
        if (!goUp)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.y < 3)
            {
                goUp = true;
                return;
            }

        }
    }
}
