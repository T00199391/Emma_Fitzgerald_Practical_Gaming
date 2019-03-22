using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour {

    ArrayList armor = new ArrayList() { "W", "C", "S", "G", "I" };
    private int playerLevel;
    Levelling level;

    // Use this for initialization
    void Start () {
        level = gameObject.GetComponent<Levelling>();
    }
	
	// Update is called once per frame
	void Update () {
        playerLevel = level.playersLevel();
    }

    //checks what level the player is and determines what armor they are using
    public char currentShield()
    {
        char currentWeapon = ' ';

        if (playerLevel > 0 && playerLevel < 5)
        {
            currentWeapon = Convert.ToChar(armor[0]);
        }
        else if (playerLevel >= 5 && playerLevel < 10)
        {
            currentWeapon = Convert.ToChar(armor[1]);
        }
        else if (playerLevel >= 10 && playerLevel < 15)
        {
            currentWeapon = Convert.ToChar(armor[2]);
        }
        else if (playerLevel >= 15 && playerLevel < 20)
        {
            currentWeapon = Convert.ToChar(armor[3]);
        }
        else
        {
            currentWeapon = Convert.ToChar(armor[4]);
        }

        return currentWeapon;
    }
}
