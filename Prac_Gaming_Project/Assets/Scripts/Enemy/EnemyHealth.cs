using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    private int currentHealth = 100;
    private int minHealth = 0;
    private Movement playerAttack;
    private int attackPower;
    Weapons weapon;
    private bool enemyDead = false;
    public Animator anim;

	// Use this for initialization
	void Start () {
        playerAttack = gameObject.GetComponent<Movement>();
        weapon = gameObject.GetComponent<Weapons>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void enemyLossHealth()
    {
        healthToLoss(weapon.currentWeapon());
        if(playerAttack.attack() && !enemyDead)
        {
            currentHealth -= attackPower;
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
            anim.SetBool("dead", true);
        }
    }

    private void healthToLoss(char weapon)
    {
        switch(weapon)
        {
            case 'W':
                attackPower = 5;
                break;
            case 'C':
                attackPower = 10;
                break;
            case 'S':
                attackPower = 15;
                break;
            case 'G':
                attackPower = 20;
                break;
            case 'I':
                attackPower = 25;
                break;
            default:
                attackPower = 0;
                break;
        }
    }
}
