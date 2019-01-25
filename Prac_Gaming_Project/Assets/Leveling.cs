using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leveling : MonoBehaviour
{
    /// <summary>
    /// the amount of exp the player has
    /// </summary>
    private int experience;
    /// <summary>
    /// the players current level
    /// </summary>
    private int currentLevel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// will take in the experience the character will get from defeating enemies and determine if the character will level up or not
    /// </summary>
    /// <param name="exp">the amount of exp the player gets from defeating an enemy</param>
    private void levelUp(int exp)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will unlock items at the shop for the character to buy upgrades from their sword and sheild
    /// </summary>
    /// <param name="level">the level the character is</param>
    private void unlockItem(int level)
    {
        throw new System.NotImplementedException();
    }
}
