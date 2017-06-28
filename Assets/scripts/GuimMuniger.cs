using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuimMuniger : MonoBehaviour {

    public static int currentScore = 0;
    public Text scoreText;
    bool gameHasEnded = false;
	
	void Update () {
        if (currentScore < 0)
            SceneManager.LoadScene("End");
        else
        scoreText.text = currentScore.ToString();        
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
        }
    }

    
}

