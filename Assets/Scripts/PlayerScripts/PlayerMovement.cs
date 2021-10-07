using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 12.0f;
    [SerializeField] private float horizontalMoveSpeed = 5.0f;
    [SerializeField] private float rotateSpeed = 2.0f;
    [SerializeField] private float jumpForce = 2.0f;
    [SerializeField] float jumpForwardForce = 2.0f;

    private Rigidbody rb;

    private string horizontalAxis = "Horizontal";
    private float horizontalMoveInput;

    private KeyCode jumpButton = KeyCode.Space;
    private bool jumpInputIsPressed;
    [SerializeField] private Transform jumpCheckPos;
    [SerializeField] private float jumpCheckRadius;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private float jumpTime = 1.0f;
    private float jumpTimeTimer = 0f;
    private bool isGrounded = false;
    private bool isJumping = false;



    private void MovePlayer()
    {
        if(isGrounded)
        {
            transform.Rotate(Vector3.up * Input.GetAxis(horizontalAxis) * rotateSpeed);

        }
        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(transform.forward * Input.GetAxis(horizontalAxis));

        }
    
    }

    private void UpdateIsGrounded()
    {
        isGrounded = Physics.CheckSphere(jumpCheckPos.position, jumpCheckRadius, whatIsGround);
        return;

    }
    
    private void Jump()
    {
        Vector3 jumpVelocity;
        jumpVelocity = transform.forward * jumpForwardForce;

        rb.velocity = jumpVelocity;

        rb.velocity += transform.up * jumpForce;

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    private void Update() {
        
    }
    private void FixedUpdate() {
        UpdateIsGrounded();

        if(isGrounded)
        {
            rb.drag = 2f;

        }
        else {
            rb.drag = 0f;

        }

        if(Input.GetKeyDown(jumpButton))
        {
            if(isGrounded)
            {
                isJumping = true;
                jumpTimeTimer = jumpTime;
                Jump();

            }

        }
        if(Input.GetKey(jumpButton))
        {
            if (isJumping)
            {
                if (jumpTimeTimer < 0)
                {
                    rb.velocity = transform.up * jumpForce;
                    jumpTimeTimer -= Time.fixedDeltaTime;

                }
                else
                {
                    isJumping = false;

                }

            }

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;

        }

        MovePlayer();

    }

}
