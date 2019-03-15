using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {
    ArrayList weapons = new ArrayList();
    private int playerLevel = 21;
    EnemyHealth enemyHealth;

	// Use this for initialization
	void Start () {
        weapons.Add("W");
        weapons.Add("C");
        weapons.Add("S");
        weapons.Add("G");
        weapons.Add("I");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

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
}
