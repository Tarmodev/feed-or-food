//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Start is called before the first frame update
    //void Start() {
    //
    //}

    // Can't the script determine its Rigidbody on its own?
    public Rigidbody rb;
    [SerializeField] float rotateSpeed = 2.0f;
    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] float maxSpeed = 20.0f;
    
    // Rigidbody will keep track of this so we don't need to
    //public float facingAngle;

    private float horizontalInput;



    private void FixedUpdate() {
        //Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        //Vector3 horizontalMove = 
        //    transform.right 
        //    * horizontalInput 
        //    * speed 
        //    * Time.fixedDeltaTime
        //    * horizontalMultiplier;
        //rb.MovePosition(rb.position + forwardMove + horizontalMove);
        transform.Rotate(Vector3.forward * horizontalInput * rotateSpeed);
        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(-1 * (transform.up) * moveSpeed);

        }

    }
    // Update is called once per frame
    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");

    }

}
