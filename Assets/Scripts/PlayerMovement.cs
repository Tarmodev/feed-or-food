using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float rotateSpeed = 2.0f;
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float maxSpeed = 20.0f;
    
    private float horizontalInput;
    
    private void FixedUpdate() {
        transform.Rotate(Vector3.up * horizontalInput * rotateSpeed);
        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce((transform.forward) * moveSpeed);

        }

    }
    
    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");

    }

}
