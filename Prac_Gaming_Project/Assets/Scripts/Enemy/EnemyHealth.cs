using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    int minHeaalth = 0;
    int currentHealth = 50;
    public Score score;
    public Animator anim;
    private bool isDead = false;
    private float timer = 1.5f;
    public GameObject healthPotion;

    private void Update()
    {
        if(isDead)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            Destroy(this.gameObject);
            timer = 1.5f;
        }
    }

    public void HealthDecrease()
    {
        currentHealth -= 10;
        EnemyDied();
    }

    private void EnemyDied()
    {
        if(currentHealth == minHeaalth)
        {
            anim.SetBool("Dead", true);
            score.ScoreIncrease();
            isDead = true;
            float x = transform.position.x;
            float y = transform.position.y;
            float z = transform.position.z;
            Vector3 enemyTran = new Vector3(x,y+1,z);
            Instantiate(healthPotion, enemyTran, Quaternion.identity);
        }
    }
}
