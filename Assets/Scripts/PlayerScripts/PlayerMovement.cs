using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float horizontalMoveSpeed = 5.0f;
    [SerializeField] private float maxSpeed = 20.0f;
    [SerializeField] private float rotateSpeed = 2.0f;
    //[SerializeField] private float jumpForce = 2.0f;

    private Rigidbody rb;

    private float horizontalMoveInput;
    private bool jumpInput;

    [SerializeField] private Transform checkPos;
    private float checkRadius;

    private bool isGrounded;
    private int whatIsGround;
    private KeyCode jumpButton = KeyCode.Space;
    private string horizontalAxis = "Horizontal";



    private void UpdateInput()
    {
        horizontalMoveInput = Input.GetAxis(horizontalAxis);
        jumpInput = Input.GetKey(jumpButton);

    }

    private void MovePlayer()
    {
        Debug.Log("MovePlaýer()");
        transform.Rotate(Vector3.up * horizontalMoveInput * rotateSpeed);
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce((transform.forward) * horizontalMoveSpeed);

        }
    
    }

    private void Jump()
    {
        throw new NotImplementedException();

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update() {
        UpdateInput();

    }

    private void FixedUpdate() {
        Collider[] hitColliders = Physics.OverlapSphere(checkPos.position, checkRadius, whatIsGround);
        if (hitColliders != null && jumpInput)
        {
            Jump();
        }

        MovePlayer();

    }

}
