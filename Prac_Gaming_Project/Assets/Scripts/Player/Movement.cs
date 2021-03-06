﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    private float moveSpeed = 10;
    private float sprintSpeed = 15;
    public GameObject cameraMove;
    private Vector3 moveDirection;
    public Animator anim;
    public Animator chestAnim;
    private float rotateSpeed = 180;
    private bool moving = false;
    private bool sprinting = false;
    private bool attacking = false;
    private bool shielding = false;
    public Transform rayObject;
    public Transform healthRay;
    float timeTaken = 1f;
    private bool paused = false;
    public Text gameOver;
    private EnemyHealth enemyHealth;
    public Slider health;
    private GameObject enemy;
    public Interactable focus;
    private bool won = false;
    private bool open = false;

    // Use this for initialization
    void Start () {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyHealth = enemy.GetComponent<EnemyHealth>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
            Debug.Log(paused);
        }

        if(!paused)
        {
            IsMoving();
            IsSprinting();
            IsAttacking();
            IsShielding();
            IsDead();
            ItemPickup();
            PlayerWon();
            InventoryActive();
        }
    }

    //checks to seee if the character is moving
    private void IsMoving()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            moving = true;
        }
        else
        {
            moving = false;
            anim.SetFloat("Speed", 0);
        }

        if (moving)
        { 
            MoveCharacter(moveSpeed);
        }
    }

    //determines which direction the character is moving in
    private void MoveCharacter(float speed)
    {
        if (!won && !attacking && !shielding && timeTaken == 1 && gameOver.text == "")
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += speed * transform.forward * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.Rotate(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += speed * transform.forward * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            }
            anim.SetFloat("Speed", (Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"))));
        }
    }

    //checks to see if the character is sprinting 
    private void IsSprinting()
    {
        if (!won && !attacking && timeTaken == 1)
        {
            if (moving && Input.GetKey(KeyCode.LeftShift))
            {
                sprinting = true;
                anim.SetBool("Sprinting", sprinting);
            }
            else
            {
                sprinting = false;
                anim.SetBool("Sprinting", sprinting);
            }

            if (sprinting)
            {
                CharacterSprinting();
            }
        }
    }

    //changes the speed at which the character moves at
    private void CharacterSprinting()
    {
        MoveCharacter(sprintSpeed);
    }

    //checks to see if the character is attacking
    private void IsAttacking()
    {
        if (Input.GetMouseButton(0) && timeTaken == 1 && !shielding && !won && !open)
        {
            attacking = true;
            anim.SetBool("Attacking", attacking);
            timeTaken -= 0.7f;
        }
        else
        {
            if(timeTaken < 1)
            {
                timeTaken += Time.deltaTime;
            }
            else if(timeTaken >= 1)
            {
                timeTaken = 1f;
            }
            attacking = false;
            anim.SetBool("Attacking", attacking);
        }

        if (Attack())
        {
            PlayerAttack();
        }
    }

    public bool Attack()
    {
        return attacking;
    }
    
    //determines if the player can attack by checking if the character is shielding first
    private void PlayerAttack()
    {
        if(!shielding)
        {
            RaycastHit hit;
            Ray myRay = new Ray(rayObject.position, rayObject.forward);
            if (Physics.Raycast(myRay, out hit,15f))
            {
                if(hit.collider.tag == "Enemy")
                {
                    enemyHealth.HealthDecrease();
                }
            }
        }   
    }

    //chechs to see if the character is shielding
    private void IsShielding()
    {
        if (Input.GetMouseButtonDown(1) && !attacking && !won)
        {
            shielding = true;
            anim.SetBool("Shielding", shielding);
        }

        if(Input.GetMouseButtonUp(1))
        {
            shielding = false;
            anim.SetBool("Shielding", shielding);
        }
    }
    
    public bool PlayerShield()
    {
        return shielding;
    }

    private void IsDead()
    {
        if(health.value == 0)
        {
            anim.SetBool("Dead", true);
            gameOver.text = "Game Over";
        }
    }

    private bool InventoryActive()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            open = !open;
            Debug.Log(open);
        }

        return open;
    }

    private void ItemPickup()
    {
        Vector3 direction = transform.forward;
        RaycastHit hit;
        float sphereRadius = 2f;
        float maxDistance = 2f;
        Vector3 origin = transform.position;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.SphereCast(origin, sphereRadius, direction, out hit, maxDistance))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.SphereCast(origin, sphereRadius, direction, out hit, maxDistance))
            {
                RemoveFocus();
            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        if(newFocus != focus)
        {
            if(focus != null)
                focus.OnDefocused();

            focus = newFocus;
        }

        newFocus.OnFocused(transform);
    }

    void RemoveFocus()
    {
        if(focus != null)
            focus.OnDefocused();

        focus = null;
    }

    public void IncreaseHealth()
    {
        health.value += 20;
    }

    public bool PlayerWon()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Vector3 direction = transform.forward;
            RaycastHit hit;
            float sphereRadius = 2f;
            float maxDistance = 2f;
            Vector3 origin = transform.position;


            if (Physics.SphereCast(origin, sphereRadius, direction, out hit, maxDistance))
            {
                if (hit.collider.tag == "Chest")
                {
                    chestAnim.SetBool("Open", true);
                    won = true;
                    anim.SetBool("Won", true);
                }
            }
        }


        return won;
    }
}
