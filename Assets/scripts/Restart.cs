﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	public void RestartGame()
    {
        SceneManager.LoadScene("Lvl1");
    }
}