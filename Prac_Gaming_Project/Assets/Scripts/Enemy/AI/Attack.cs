using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : NPCBaseFSM {

    bool paused = false;

    private bool IsPaused()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
        }

        return paused;
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        base.OnStateEnter(animator, stateInfo, layerIndex);
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        if (!IsPaused())
        {
            Time.timeScale = 1;
            NPC.transform.LookAt(opponent.transform.position);
            NPC.GetComponent<GoblinAI>().StartAttacking();
            
        }
        else
        {
            Time.timeScale = 0;
        }
    }

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        NPC.GetComponent<GoblinAI>().StopAttacking();
    }
}
