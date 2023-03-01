using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    

    public float xRange = 8.5f;


    public Logic_Script logic;
    public bool FarmerAlive = true;

    [SerializeField] private float movementSpeed = 6f;
    private bool isFacingRight = true;
    private Rigidbody2D rb;
    private Animator anim; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
    }

    void FixedUpdate()
    {

        float moveInput = Input.GetAxis("Horizontal"); 
        rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y);
        anim.SetBool("IsMoving", moveInput != 0f);

        if (moveInput > 0 && !isFacingRight) 
        {
            Flip();
        }
        else if (moveInput < 0 && isFacingRight) 
        {
            Flip();
        }
         if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}

      