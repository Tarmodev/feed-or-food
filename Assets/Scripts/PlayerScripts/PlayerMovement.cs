using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float horizontalMoveSpeed = 5.0f;
    [SerializeField] private float maxSpeed = 20.0f;
    [SerializeField] private float rotateSpeed = 2.0f;
    [SerializeField] private Transform jumpCheckPos;
    [SerializeField] private float jumpForce = 2.0f;
    [SerializeField] private float jumpTime = 1.0f;

    private Rigidbody rb;

    private float horizontalMoveInput;
    private bool jumpInput;

    private KeyCode jumpButton = KeyCode.Space;
    private string horizontalAxis = "Horizontal";

    [SerializeField] private float checkRadius;

    private bool isGrounded;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;

    private bool isJumping = false;


    private void UpdateInput()
    {
        horizontalMoveInput = Input.GetAxis(horizontalAxis);
        jumpInput = Input.GetKey(jumpButton);

    }

    private void MovePlayer()
    {
        //Debug.Log("MovePlayer()");
        transform.Rotate(Vector3.up * horizontalMoveInput * rotateSpeed);
        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce((transform.forward) * horizontalMoveSpeed);

        }
    
    }

    private bool CheckIfIsGrounded()
    {
        Collider[] hitColliders = Physics.OverlapSphere(jumpCheckPos.position, checkRadius, whatIsGround);
        return hitColliders != null;

    }

    private void Jump()
    {
        rb.velocity = Vector3.up * jumpForce;

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
            Debug.Log("Jumped();");

        }

        MovePlayer();
        if(jumpInput)
        {
            if(jumpTimeCounter < 0.0f)
            {
                rb.velocity = Vector3.up * jumpForce;
                jumpTime -= Time.deltaTime;

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
