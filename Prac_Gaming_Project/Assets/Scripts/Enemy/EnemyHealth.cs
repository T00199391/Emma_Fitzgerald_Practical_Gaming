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

    public void healthDecrease()
    {
        currentHealth -= 10;
        enemyDied();
    }

    private void enemyDied()
    {
        if(currentHealth == minHeaalth)
        {
            anim.SetBool("Dead", true);
            score.scoreIncrease();
            isDead = true;
        }
    }
}
