using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour {

    float maxDistance = 3f;
    float disBetween;
    public Transform enemy;
    public GameObject target;
    private Health health;
    private EnemyHealth eHealth;


	// Use this for initialization
	void Start () {
        health = FindObjectOfType<Health>();
        eHealth = FindObjectOfType<EnemyHealth>();
    }
	
	// Update is called once per frame
	void Update () {
        canAttack();
	}

    public float findingDistance()
    {
        disBetween = Vector3.Distance(transform.position, enemy.position);
        return disBetween;
    }

    public bool isNear(float dis)
    {
        if(dis <= maxDistance)
        {
            return true;
        }

        return false;
    }

    public void canAttack()
    {
        if(isNear(findingDistance()))
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                eHealth.isAttacked();

                if(eHealth.isDead())
                {
                    Destroy(target);
                }
            }
            if(Input.GetKeyDown(KeyCode.P))
            {
                health.isAttacked();
            }
        }
    }
}
