using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    private int currentHealth = 100;
    private int minHealth = 0;
    private Movement playerAttack;
    private int attackePower;
    Weapons weapon;
    private bool enemyDead = false;

	// Use this for initialization
	void Start () {
        playerAttack = gameObject.GetComponent<Movement>();
        weapon = gameObject.GetComponent<Weapons>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void enemyLossHealth()
    {
        healthToLoss(weapon.currentWeapon());
        if(playerAttack.attack() && !enemyDead)
        {
            currentHealth -= attackePower;
            Debug.Log(currentHealth);
        }

        if(currentHealth == minHealth)
        {
            enemyDead = true;
            isDead();
        }
    }

    private void isDead()
    {
        if(enemyDead)
        {
            Debug.Log("Enemy Died");
        }
    }

    private void healthToLoss(char weapon)
    {
        switch(weapon)
        {
            case 'W':
                attackePower = 5;
                break;
            case 'C':
                attackePower = 10;
                break;
            case 'S':
                attackePower = 15;
                break;
            case 'G':
                attackePower = 20;
                break;
            case 'I':
                attackePower = 25;
                break;
            default:
                attackePower = 0;
                break;
        }
    }
}
