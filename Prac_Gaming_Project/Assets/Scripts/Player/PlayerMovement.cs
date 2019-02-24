using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5;
    private float sprintSpeed = 10;
    public CharacterController controller;
    private Vector3 moveDirection;
    public Animator anim;
    public Transform pivot;
    private float rotateSpeed = 10;
    public GameObject playerModel;
    private bool moving = false;
    private bool sprinting = false;
    private bool attacking = false;
    private bool shielding = false;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isMoving();
        isSprinting();
        isAttacking();
        isShielding();
    }

    private void isMoving()
    {
        if (!(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S)))
        {
            moving = true;
        }
        else
        {
            moving = false;
        }

        if (moving)
        {
            moveCharacter(moveSpeed);
        }
    }

    private void moveCharacter(float speed)
    {
        moveDirection = (transform.forward * Input.GetAxis("Vertical") * speed) + (transform.right * Input.GetAxis("Horizontal") * speed);
        moveDirection = moveDirection.normalized * speed;

        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis("Vertical") * moveSpeed);

        controller.Move(moveDirection * Time.deltaTime);

        //Move the player is different directions based on camera look direction
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.rotation = Quaternion.Euler(0f, pivot.rotation.eulerAngles.y, 0f);
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x, 0f, moveDirection.z));
            playerModel.transform.rotation = Quaternion.Slerp(playerModel.transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }

        anim.SetFloat("Speed", (Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"))));
    }

    private void isSprinting()
    {
        if (moving && Input.GetKey(KeyCode.LeftShift))
        {
            sprinting = true;
        }
        else
        {
            sprinting = false;
        }

        if (sprinting)
        {
            characterSprinting();
        }
    }

    private void characterSprinting()
    {
        moveCharacter(sprintSpeed);
    }

    private void isAttacking()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            attacking = true;
        }
        else
        {
            attacking = false;
        }

        playerAttacks();
    }

    private void playerAttacks()
    {
        //anim.SetBool("IsAttacking", attacking);
    }

    private void isShielding()
    {
        if(Input.GetKey(KeyCode.E))
        {
            shielding = true;
        }
        else
        {
            shielding = false;
        }

        playerShield();
    }

    private void playerShield()
    {
        //anim.SetBool("IsShielding",shielding);
    }
}
