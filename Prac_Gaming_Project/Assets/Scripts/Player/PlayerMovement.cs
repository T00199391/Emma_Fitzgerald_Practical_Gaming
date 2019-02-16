using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// the speed at which the character will move at
    /// </summary>
    public float movementSpeed = 3;
    /// <summary>
    /// the speed at which the character will turn
    /// </summary>
    private float turnSpeed=130;
    /// <summary>
    /// the speed at which the character will sprint
    /// </summary>
    private float sprintSpeed=4;
    /// <summary>
    /// the speed at which the character will turn at when sprinting
    /// </summary>
    private float sprintTurnSpeed=150;

    Vector3 vec = new Vector3(0, 0, 2);
    Vector3 vec2 = new Vector3(2, 0, 0);

    public float turningSpeed = 150;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        isMoving();
        //isSpriting();
        //isDodging();
        //isAttacking();
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }

    /// <summary>
    /// This will determine if the player is moving and what direction they are moving in
    /// </summary>
    private void isMoving()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            moveForward(movementSpeed);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            moveLeft(turnSpeed);
        }
    }

    /// <summary>
    /// This will determine if the character is moving
    /// </summary>
    private void isSpriting()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            moveForward(sprintSpeed);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            //moveBack(sprintSpeed);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            moveLeft(sprintTurnSpeed);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            //moveRight(sprintTurnSpeed);
        }
    }

    /// <summary>
    /// This will determine if the character is dodging
    /// </summary>
    private void isDodging()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Q))
        {
            dodgeForward();
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.Q))
        {
            dodgeBackward();
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.Q))
        {
            dodgeLeft();
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.Q))
        {
            dodgeRight();
        }
    }

    /// <summary>
    /// This will dtermine what attack the player is doing
    /// </summary>
    private void isAttacking()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            attack();
        }
        if(Input.GetKey(KeyCode.Space))
        {
            specialAttack();
        }
    }

    /// <summary>
    /// will move the character in a forward direction
    /// </summary>
    /// <param name="movementSpeed">the speed at which the character will move at</param>
    private void moveForward(float ms)
    {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
    }

    /// <summary>
    /// will make the character turn 180 degrees ata a given speed
    /// </summary>
    /// <param name="turnSpeed">the speed at which the character will turn</param>
    //private void moveBack(float ms)
    //{
    //    transform.position -= ms * transform.forward * Time.deltaTime;
    //}

    /// <summary>
    /// will make the character turn 90 degrees right at a given speed
    /// </summary>
    /// <param name="turnSpeed">the speed at which the character will turn</param>
    //private void moveRight(float ts)
    //{
    //    transform.Rotate(Vector3.up, ts * Time.deltaTime);
    //}

    /// <summary>
    /// will make the character turn 90 degrees left at a given speed
    /// </summary>
    /// <param name="turnSpeed">the speed at which the character will turn</param>
    private void moveLeft(float ts)
    {
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }

    /// <summary>
    /// will make the character move forward a certain distance to dodge enemy attackes
    private void dodgeForward()
    {

    }

    /// <summary>
    /// will make the character move back a certain distance to dodge enemy attacks
    private void dodgeBackward()
    {
        
    }

    /// <summary>
    /// will make the character move right a certain distance to dodge enemy attacks
    private void dodgeRight()
    {
        
    }

    /// <summary>
    /// will make the character move left a certain distance to dodge enemy attacks
    private void dodgeLeft()
    {
        
    }

    /// <summary>
    /// will make the character swing the weapon they are holding at an enemy or at the eniviornment to break an item
    /// </summary>
    private void attack()
    {
        
    }

    /// <summary>
    /// will let the character do a 360 swing of their sword to hit many enemies at once
    /// </summary>
    private void specialAttack()
    {
        
    }
}
