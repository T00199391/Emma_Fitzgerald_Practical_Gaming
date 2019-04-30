using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    private float moveSpeed = 10;
    private float sprintSpeed = 15;
    public GameObject cameraMove;
    private Vector3 moveDirection;
    public Animator anim;
    private float rotateSpeed = 180;
    private bool moving = false;
    private bool sprinting = false;
    private bool attacking = false;
    private bool shielding = false;
    public Transform rayObject;
    float timeTaken = 1f;
    private bool paused = false;
    public Text gameOver;
    public EnemyHealth enemy;

    // Use this for initialization
    void Start () {
        
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
        if (!attacking && timeTaken == 1 && gameOver.text == "")
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
        if (!attacking && timeTaken == 1)
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
        if (Input.GetMouseButtonDown(0) && timeTaken == 1 && !shielding)
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
            if (Physics.Raycast(myRay, out hit,10f))
            {
                Debug.DrawLine(myRay.origin, hit.point, Color.red);
                if(hit.collider.tag == "Enemy")
                {
                    //Debug.Log("Attack");
                    enemy.HealthDecrease();
                }
            }
        }   
    }

    //chechs to see if the character is shielding
    private void IsShielding()
    {
        if (Input.GetMouseButtonDown(1) && timeTaken == 1 && !attacking)
        {
            shielding = true;
            anim.SetBool("Shielding", shielding);
            timeTaken -= 0.7f;
        }
        else
        {
            if (timeTaken < 1)
            {
                timeTaken += Time.deltaTime;
            }
            else if (timeTaken >= 1)
            {
                timeTaken = 1f;
            }
            shielding = false;
            anim.SetBool("Shielding", shielding);
        }

        if (shielding)
        {
            PlayerShield();
        }
    }


    public bool PlayerShield()
    {
        return shielding;
    }
}
