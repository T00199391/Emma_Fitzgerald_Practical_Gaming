using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    public Slider slider;
    public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerDied();
	}

    public void PlayerHealthDecrease(int value)
    {
        slider.value -= value;
    }

    private void PlayerDied()
    {
        if(slider.value == 0)
        {
            anim.SetBool("Won", true);
        }
    }
}
