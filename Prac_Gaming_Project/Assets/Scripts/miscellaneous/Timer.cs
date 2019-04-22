using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    float timer = 10f;
    public Text gameOverText;
    public Text timerText;
    public Animator anim;
    Movement over;
    private bool paused = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
            paused = !paused;

        if (!paused)
        {
            timer -= Time.deltaTime;

            int seconds = (int)(timer % 60);
            int minutes = (int)(timer / 60) % 60;
            string timerString = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
            timerText.text = timerString;

            if (timer <= 0)
            {
                gameOver();
                timerText.text = "";
            }
        }
	}

    private void gameOver()
    {
        anim.SetBool("GameOver", true);
        gameOverText.text = "Game Over";
    }
}
