using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {
    ArrayList weapons = new ArrayList() { "W", "C", "S", "G", "I" };
    private int playerLevel;

	// Use this for initialization
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //checks what level the player is and determines what weapon they are using
    public char currentWeapon()
    {
        char currentWeapon = ' ';

        if(playerLevel > 0 && playerLevel < 5)
        {
            currentWeapon = Convert.ToChar(weapons[0]);
        }
        else if(playerLevel >=5 && playerLevel < 10)
        {
            currentWeapon = Convert.ToChar(weapons[1]);
        }
        else if (playerLevel >= 10 && playerLevel < 15)
        {
            currentWeapon = Convert.ToChar(weapons[2]);
        }
        else if (playerLevel >= 15 && playerLevel < 20)
        {
            currentWeapon = Convert.ToChar(weapons[3]);
        }
        else
        {
            currentWeapon = Convert.ToChar(weapons[4]);
        }

        return currentWeapon;
    }

    public void currentLevel(int level)
    {
        playerLevel = level;
    }
}
