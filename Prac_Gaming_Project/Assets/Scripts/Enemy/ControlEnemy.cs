using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemy : MonoBehaviour {

    float maxDistance = 3f;
    float disBetween;
    public Transform enemy;
    public GameObject target;
    private EnemyHealth enemyHealth;


	// Use this for initialization
	void Start () {
        enemyHealth = FindObjectOfType<EnemyHealth>();
    }
	
	// Update is called once per frame
	void Update () {
        canAttack();
	}

    //This will find the distance between the player and the character
    public float findingDistance()
    {
        disBetween = Vector3.Distance(transform.position, enemy.position);
        return disBetween;
    }

    //This is used to determine if the player is close to the enemy
    public bool isNear(float dis)
    {
        if(dis <= maxDistance)
        {
            return true;
        }

        return false;
    }

    //This will see if the player is attacking the enemy or the enemy is attacking the player
    public void canAttack()
    {
        if(isNear(findingDistance()))
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                enemyHealth.isAttacked();

                if(enemyHealth.isDead())
                {
                    Destroy(target);
                }
            }
            if(Input.GetKeyDown(KeyCode.P))
            {
                
            }
        }
    }
}
