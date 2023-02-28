using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    /*public float speed = 5.0f;
    public float xRange = 5.0f;

    private float horizontalInput;

    public Logic_Script logic;
    public bool FarmerAlive = true;
    private Animator animator;
    private bool rightmovement = true;
    public bool isFacingRight = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        animator.SetBool("isMoving", horizontalInput != 0f);

        if (horizontalInput > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (horizontalInput < 0 && isFacingRight)
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
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}*/
    // La velocidad de movimiento del jugador
    [SerializeField] private float movementSpeed = 5f;
    // Determina si el jugador está mirando hacia la derecha
    private bool isFacingRight = true;
    // El componente Rigidbody2D del jugador
    private Rigidbody2D rb;
    // El componente Animator del jugador
    private Animator anim;

    void Start()
    {
        // Obtiene el componente Rigidbody2D del jugador
        rb = GetComponent<Rigidbody2D>();
        // Obtiene el componente Animator del jugador
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // Obtiene el valor dado por el input
        float moveInput = Input.GetAxis("Horizontal");
        // Mueve el jugador en la dirección horizontal deseada
        rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y);

        // Actualiza la animación de caminar del jugador
        anim.SetBool("IsMoving", moveInput != 0f);

        // Si el jugador se mueve hacia la derecha y no está mirando hacia la derecha, voltea el sprite del jugador
        if (moveInput > 0 && !isFacingRight)
        {
            Flip();
        }
        // Si el jugador se mueve hacia la izquierda y está mirando hacia la derecha, voltea el sprite del jugador
        else if (moveInput < 0 && isFacingRight)
        {
            Flip();
        }
    }

    // Voltea el sprite del jugador horizontalmente
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}

