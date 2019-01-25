using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// the speed at which the character will move at
    /// </summary>
    private float movementSpeed;
    /// <summary>
    /// the speed at which the character will turn
    /// </summary>
    private float turnSpeed;
    /// <summary>
    /// the speed at which the character will dodge at
    /// </summary>
    private float dodgeSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// will move the character in a forward direction
    /// </summary>
    /// <param name="movementSpeed">the speed at which the character will move at</param>
    private void moveForward(float movementSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will make the character turn 180 degrees ata a given speed
    /// </summary>
    /// <param name="turnSpeed">the speed at which the character will turn</param>
    private void moveBack(float turnSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will make the character turn 90 degrees right at a given speed
    /// </summary>
    /// <param name="turnSpeed">the speed at which the character will turn</param>
    private void moveRight(float turnSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will make the character turn 90 degrees left at a given speed
    /// </summary>
    /// <param name="turnSpeed">the speed at which the character will turn</param>
    private void moveLeft(float turnSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will increase the speed of the character in a given direction
    /// </summary>
    /// <param name="sprintSpeed">the speed at which the character will run at</param>
    private void characterSprint(float sprintSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will make the character move forward a certain distance to dodge enemy attackes
    /// </summary>
    /// <param name="dodgeSpeed">the speed at which the character will dodge at</param>
    private void dodgeForward(float dodgeSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will make the character move back a certain distance to dodge enemy attacks
    /// </summary>
    /// <param name="dodgeSpeed">the speed at which the character will dodge at</param>
    private void dodgeBackward(float dodgeSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will make the character move right a certain distance to dodge enemy attacks
    /// </summary>
    /// <param name="dodgeSpeed">the speed at which the character will dodge at</param>
    private void dodgeRight(float dodgeSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will make the character move left a certain distance to dodge enemy attacks
    /// </summary>
    /// <param name="dodgeSpeed">the speed at which the character will dodge at</param>
    private void dodgeLeft(float dodgeSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will make the character swing the weapon they are holding at an enemy or at the eniviornment to break an item
    /// </summary>
    private void attack()
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// will let the character do a 360 swing of their sword to hit many enemies at once
    /// </summary>
    private void specialAttack()
    {
        throw new System.NotImplementedException();
    }
}
