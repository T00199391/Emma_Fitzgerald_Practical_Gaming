using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public Text scoreText;
    private int currentScore = 0;

	// Use this for initialization
	void Start () {
        scoreText.text = "Score: " + currentScore;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + currentScore;
    }

    public void scoreIncrease()
    {
        currentScore += 100;
    }
}
