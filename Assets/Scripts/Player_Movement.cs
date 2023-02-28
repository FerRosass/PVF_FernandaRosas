using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float xRange = 5.0f;

    private float horizontalInput;

    public Logic_Script logic;
    public bool FarmerAlive = true;
    private Animator animator;
    bool rightmovement = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        animator.SetFloat("Horizontal", Mathf.Abs(horizontalInput));
        Direction(horizontalInput);
    }
    void Direction(float horizontalInput)
    {
        if(rightmovement= true && horizontalInput<0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        else if(rightmovement = false && horizontalInput > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
}
