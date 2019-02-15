using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    Text gameOverText;
    PlayerHealth health;

    // Use this for initialization
    void Start () {
        gameOverText = gameObject.GetComponentInChildren<Text>();
        health = FindObjectOfType<PlayerHealth>();
    }
	
	// Update is called once per frame
	void Update () {
        gameOver();
	}

    public void gameOver()
    {
        if(health.isDead())
            gameOverText.text = "Game Over";
    }
}
