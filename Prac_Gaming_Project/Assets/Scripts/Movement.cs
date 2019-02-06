using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float movementSpeed = 3;
    private float turningSpeed = 180;
    private float sprintSpeed = 5;
    private float sprintTurningSpeed = 200;
    private Vector3 dodge = new Vector3(0, 0, 2);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        isMoving();
        isSprinting();
        isDodging();
	}

    private void isMoving()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            moveVer(movementSpeed);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            moveHor(turningSpeed);
        }
    }

    private void isSprinting()
    {
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) && Input.GetKey(KeyCode.LeftShift))
        {
            sprintVer(sprintSpeed);
        }
        if((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.LeftShift))
        {
            sprintHor(sprintTurningSpeed);
        }
    }

    private void isDodging()
    {
        if(Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Tab))
        {
            dodgingForward();
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.Tab))
        {
            dodgingBack();
        }
    }

    private void moveVer(float ms)
    {
        float vertical = Input.GetAxis("Vertical") * ms * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }

    private void moveHor(float ts)
    {
        float horizontal = Input.GetAxis("Horizontal") * ts * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
    }

    private void sprintVer(float ss)
    {
        //float vertical = Input.GetAxis("Vertical") * ss * Time.deltaTime;
        //transform.Translate(0, 0, vertical);
        moveVer(ss);
    }

    private void sprintHor(float sts)
    {
        //float horizontal = Input.GetAxis("Horizontal") * sts * Time.deltaTime;
        //transform.Rotate(0, horizontal, 0);
        moveHor(sts);
    }

    private void dodgingForward()
    {
        
    }

    private void dodgingBack()
    { 

    }
}
