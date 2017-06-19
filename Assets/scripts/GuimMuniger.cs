using UnityEngine.UI;
using UnityEngine;

public class GuimMuniger : MonoBehaviour {

    public static int currentScore = 0;
    public Text scoreText;
    bool gameHasEnded = false;
	
	void Update () {
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

