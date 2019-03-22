using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour {

    private int attackPower;
    private string shieldType;
    private int defence;
    private int playerLevel;
    private int playerExp;
    private int expNeeded;
    public Text playerInfo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.I))
        {
            playerInfo.text = "Level: " + playerLevel + "\nExp: " + playerExp + "/" + expNeeded 
                              + "\nAttack Power: " + attackPower + "\nDefence: " + defence + "\nShield: " + shieldType;
        }
        else
        {
            playerInfo.text = "";
        }
	}

    public void getWeaponInfo(int weapon)
    {
        attackPower = weapon;
    }

    public void getShieldInfo(string shield)
    {
        shieldType = shield;
    }

    public void getArmorInfo(int armor)
    {
        defence = armor;
    }

    public void getPlayerLevelAndExp(int level,int currentExp, int exp)
    {
        playerLevel = level;
        playerExp = currentExp;
        expNeeded = exp;
    }
}
