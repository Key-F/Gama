﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collInfo)
    {
        if (collInfo.collider.tag == "EvilWall")
        {
            //Debug.Log("pizda nam");
            Application.LoadLevel("Lvl1");
        }
    
    }


}
