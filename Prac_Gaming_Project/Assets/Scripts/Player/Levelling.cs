using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levelling : MonoBehaviour {

    int currentLevel = 1;
    int currentExp = 0;
    int expNeeded = 100;
    private PlayerInfo info;


	// Use this for initialization
	void Start () {
        info = gameObject.GetComponent<PlayerInfo>();
	}
	
	// Update is called once per frame
	void Update () {
        playerLevelUp();
	}

    //checks the current level of the player and determine how much exp is needed till the next level
    private void determineExpNeeded()
    {
        if(currentLevel >= 1 && currentLevel < 5)
        {
            expNeeded += 125;
        }
        else if(currentLevel >= 5 && currentLevel < 10)
        {
            expNeeded += 150;
        }
        else if(currentLevel >= 10 && currentLevel < 15)
        {
            expNeeded += 175;
        }
        else if(currentLevel >= 15 && currentLevel < 20)
        {
            expNeeded += 200;
        }
        else
        {
            expNeeded += 225;
        }
    }

    //checks to see if the current exp earned by the player is equal to the exp needed to level up
    private void playerLevelUp()
    {
        if(currentExp == expNeeded)
        {
            currentLevel++;
            determineExpNeeded();
        }
        
        if(currentExp > expNeeded)
        {
            currentExp = currentExp - expNeeded;
            currentLevel++;
            determineExpNeeded();
        }
    }

    //This will return the players current level so it can be used in different scripts
    public int playersLevel()
    {
        return currentLevel;
    }

    //This will get an int value from a different script and add the exp earned by the player to their current exp
    public void increaseExp(int exp)
    {
        currentExp += exp;
    }
}
