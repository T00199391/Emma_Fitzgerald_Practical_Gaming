using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour {

    ArrayList armor = new ArrayList() { "W", "C", "S", "G", "I" };
    private int playerLevel;
    Levelling level;
    PlayerInfo info;
    private int defence = 5;

    // Use this for initialization
    void Start()
    {
        level = gameObject.GetComponent<Levelling>();
        info = gameObject.GetComponent<PlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        //playerLevel = level.playersLevel();
        //info.getArmorInfo(defence);
    }

    //checks what level the player is and determines what weapon they are using
    public char currentArmor()
    {
        char currentArmor = ' ';

        if (playerLevel > 0 && playerLevel < 5)
        {
            currentArmor = Convert.ToChar(armor[0]);
        }
        else if (playerLevel >= 5 && playerLevel < 10)
        {
            currentArmor = Convert.ToChar(armor[1]);
            defence = 10;
        }
        else if (playerLevel >= 10 && playerLevel < 15)
        {
            currentArmor = Convert.ToChar(armor[2]);
            defence = 15;
        }
        else if (playerLevel >= 15 && playerLevel < 20)
        {
            currentArmor = Convert.ToChar(armor[3]);
            defence = 20;
        }
        else
        {
            currentArmor = Convert.ToChar(armor[4]);
            defence = 25;
        }

        return currentArmor;
    }
}
