using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paused : MonoBehaviour {

    public Text pausedText;
    private bool paused = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
        }

        if(paused)
        {
            pausedText.text = "Paused";
        }
        else
        {
            pausedText.text = "";
        }
    }
}
