﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collInfo)
    {
        if (collInfo.collider.tag == "EvilWall")
        {
            //Debug.Log("pizda nam");
            //Application.LoadLevel("Lvl1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            GuimMuniger.currentScore = 0;

        }
    
    }


}
