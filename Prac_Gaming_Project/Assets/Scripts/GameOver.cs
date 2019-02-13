using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    Text gameOverText;
    Health health;

    // Use this for initialization
    void Start () {
        gameOverText = gameObject.GetComponentInChildren<Text>();
        health = FindObjectOfType<Health>();
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
