using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour {

    public Transform ball;
    public Rigidbody bull; // lul
    private int JustSpawnedTimer = 0;

    void OnCollisionEnter(Collision collInfo)
    {
        if (collInfo.collider.tag == "EvilWall")
        {
            //Debug.Log("pizda nam");
            //Application.LoadLevel("Lvl1"); 
            if (BallControlCSharp.hardcore == true)
            {
                JustSpawnedTimer += 50;
                ball.position = new Vector3(0, 1.34f, 0);

               if ((BallControlCSharp.KeyPressed == true) && (ball.position == new Vector3(0, 1.34f, 0)))
                    Debug.Log("hui");   
                //ball.position = new Vector3(0, 1.34f, 0);
                



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

    private void OnLevelWasLoaded(int level)
    {
        JustSpawnedTimer += 50;
    }
    private void FixedUpdate()
    {
        if ((JustSpawnedTimer > 0))
        {
            ball.position = new Vector3(0, 1.34f, 0);
            bull.angularVelocity = Vector3.zero;
            bull.velocity = Vector3.zero;
            //bull.AddForce(0, 0, 0);
            JustSpawnedTimer--;
        }
    }




}
