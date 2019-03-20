using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelling : MonoBehaviour {

    Weapons weapon;
    int currentLevel = 1;
    int currentExp = 0;
    int expNeeded = 100;


	// Use this for initialization
	void Start () {
        weapon = gameObject.GetComponent<Weapons>();
	}
	
	// Update is called once per frame
	void Update () {
        weapon.currentLevel(currentLevel);
	}

    //checks the current level of the player and determine how much exp is needed till the next level
    private void playerLevel()
    {
        if(currentLevel >= 1 && currentLevel < 5)
        {
            expNeeded += 25;
        }
        else if(currentLevel >= 5 && currentLevel < 10)
        {
            expNeeded += 50;
        }
        else if(currentLevel >= 10 && currentLevel < 15)
        {
            expNeeded += 75;
        }
        else if(currentLevel >= 15 && currentLevel < 20)
        {
            expNeeded += 100;
        }
        else
        {
            expNeeded += 125;
        }
    }
}
