using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 20.0f;
    [SerializeField] private float horizontalMoveSpeed = 5.0f;
    [SerializeField] private float rotateSpeed = 2.0f;
    [SerializeField] private float jumpForce = 2.0f;

    private Rigidbody rb;

    private string horizontalAxis = "Horizontal";
    private float horizontalMoveInput;

    private KeyCode jumpButton = KeyCode.Space;
    private bool jumpInput;
    [SerializeField] private Transform jumpCheckPos;
    [SerializeField] private float jumpCheckRadius;
    [SerializeField] private LayerMask whatIsGround;
    private bool isGrounded;
    private bool isJumping = false;
    [SerializeField] private float jumpTime = 1.0f;
    private float jumpTimeCounter;



    private void UpdateInput()
    {
        horizontalMoveInput = Input.GetAxis(horizontalAxis);
        jumpInput = Input.GetKey(jumpButton);

    }

    private void MovePlayer()
    {
        transform.Rotate(Vector3.up * horizontalMoveInput * rotateSpeed);
        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce((transform.forward) * horizontalMoveSpeed);

        }
    
    }

    private bool CheckIfIsGrounded()
    {
        bool output = Physics.CheckSphere(jumpCheckPos.position, jumpCheckRadius, whatIsGround);
        return output;

    }
    
    private void Jump()
    {
        rb.velocity += Vector3.up * jumpForce;

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update() {
        UpdateInput();

    }

    private void FixedUpdate() {

        isGrounded = CheckIfIsGrounded();
        if(isGrounded && jumpInput)
        {
            Jump();

        }

        MovePlayer();
        if(jumpInput)
        {
            if(jumpTimeCounter < 0.0f)
            {
                rb.velocity = Vector3.up * jumpForce;
                jumpTime -= Time.fixedDeltaTime;

            }
            else
            {
                isJumping = false;

            }

        }
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;

        }
    }

}
