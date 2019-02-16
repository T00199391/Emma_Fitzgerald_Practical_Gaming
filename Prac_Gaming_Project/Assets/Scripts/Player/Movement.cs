using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float movementSpeed = 3;
    private float turningSpeed = 180;
    private float sprintSpeed = 5;
    private float sprintTurningSpeed = 200;
    private Vector3 dodge = new Vector3(0, 0, 2);
    private PlayerHealth gainHealth;

    // Use this for initialization
    void Start () {
        gainHealth = FindObjectOfType<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        isMoving();
        isSprinting();
        usingShield();
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

    public bool usingShield()
    {
        if(Input.GetKey(KeyCode.E))
        {
            return true;
        }
        else
        {
            return false;
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
        moveVer(ss);
    }

    private void sprintHor(float sts)
    {
        moveHor(sts);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Health"))
        {
            Destroy(other.gameObject);
            gainHealth.getHelath();
        }
    }
}
