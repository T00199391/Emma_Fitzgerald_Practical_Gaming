using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoblinAI : MonoBehaviour {

    Animator anim;

    private GameObject player;

    public static bool isAttacking = false;

    private float timer = 2f;

    private EnemyController slider;

    private Movement shield;

    public GameObject GetPlayer()
    {
        return player;
    }

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        slider = GetComponent<EnemyController>();
        player = GameObject.FindGameObjectWithTag("Player");
        shield = player.GetComponent<Movement>();
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("distance", Vector3.Distance(transform.position, player.transform.position));
        anim.SetFloat("attackDistance", Vector3.Distance(transform.position, player.transform.position));
    }

    public void StartAttacking()
    {
        if (shield.PlayerShield() == false)
        {
            if (timer <= 2 && timer > 0)
            {
                timer -= Time.deltaTime;
            }

            if (timer >= 1.47 && timer <= 1.5)
            {
                slider.PlayerHealthDecrease(5);
            }

            if (timer <= 0)
            {
                timer = 2f;
            }
        }
    }

    public void StopAttacking()
    {
        isAttacking = false;
    }
}
