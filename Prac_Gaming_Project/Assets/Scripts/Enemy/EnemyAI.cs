using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    private Animator anim;
    private bool idle;
    private bool chase;

    public enum EnemyState { idle,chase};
    public EnemyState enemyState;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		switch(enemyState)
        {
            
        }
	}
}
