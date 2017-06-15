using UnityEngine.UI;
using UnityEngine;

public class GuimMuniger : MonoBehaviour {

    public static int currentScore = 0;
    public Text scoreText;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        scoreText.text = currentScore.ToString();
	}
}
