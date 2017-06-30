using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour {

    public Transform ball;

    void OnCollisionEnter(Collision collInfo)
    {
        if (collInfo.collider.tag == "EvilWall")
        {
            //Debug.Log("pizda nam");
            //Application.LoadLevel("Lvl1"); 
            if (BallControlCSharp.hardcore == true)
            {
                ball.position = new Vector3(0, 1.34f, 0);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            GuimMuniger.currentScore -= 1;

        }

        if (collInfo.collider.name == "EndGame")
        {
            Debug.Log("");
            SceneManager.LoadScene("End");
        }

        if (collInfo.collider.tag == "EndLvl")
        {
            Debug.Log("go otsuda");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);     
            
        }

    }


}
