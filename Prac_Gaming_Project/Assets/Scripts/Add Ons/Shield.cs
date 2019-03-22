using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shield : MonoBehaviour {

    ArrayList shields = new ArrayList() { "W", "C", "S", "G", "I" };
    private int playerLevel;
    Levelling level;
    PlayerInfo info;
    private string shield = "Wooden";

    // Use this for initialization
    void Start () {
        level = gameObject.GetComponent<Levelling>();
        info = gameObject.GetComponent<PlayerInfo>();
    }
	
	// Update is called once per frame
	void Update () {
        playerLevel = level.playersLevel();
        info.getShieldInfo(shield);
    }

    //checks what level the player is and determines what shield they are using
    public char currentShield()
    {
        char currentWeapon = ' ';

        if (playerLevel > 0 && playerLevel < 5)
        {
            currentWeapon = Convert.ToChar(shields[0]);
        }
        else if (playerLevel >= 5 && playerLevel < 10)
        {
            currentWeapon = Convert.ToChar(shields[1]);
            shield = "Copper";
        }
        else if (playerLevel >= 10 && playerLevel < 15)
        {
            currentWeapon = Convert.ToChar(shields[2]);
            shield = "Silver";
        }
        else if (playerLevel >= 15 && playerLevel < 20)
        {
            currentWeapon = Convert.ToChar(shields[3]);
            shield = "Gold";
        }
        else
        {
            currentWeapon = Convert.ToChar(shields[4]);
            shield = "Idrium";
        }

        return currentWeapon;
    }
}
