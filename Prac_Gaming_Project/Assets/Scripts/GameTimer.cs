using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    public Text GameTimerText;
    float gameTimer = 480f;
    Text timerText;
    RectTransform position;

    // Use this for initialization
    void Start () {
        timerText = gameObject.GetComponentInChildren<Text>();
        position = timerText.GetComponentInChildren<RectTransform>();
        setPosition(481, 274, 0);
        timerText.text = gameTimer.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        gameTimer -= Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;

        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        GameTimerText.text = timerString;
    }

    public void setPosition(int x, int y, int z)
    {
        Vector3 distance = new Vector3(x, y, z);
        position.Translate(distance);
    }
}
