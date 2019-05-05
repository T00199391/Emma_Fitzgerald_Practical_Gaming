using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Won : MonoBehaviour {

    private GameObject player;
    private Movement playerWon;
    public Text WonTxt;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerWon = player.GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
		if(playerWon.PlayerWon())
        {
            WonTxt.text = "You Won!!";
        }
	}
}
