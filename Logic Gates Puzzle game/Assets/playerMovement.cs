using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed = 2f;

    //refernce to the rigid body
    public Rigidbody2D rb;

    //holds two values, an x and a y
    public Vector2 movement;

    // Update is called once per frame
    //handle input
    void Update()
    {
        //gives -1 if we hit left gives 1 if we hit right
        //works with wasd and controllers
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    //create FixedUpdate because updating once per frame is not good for pysics
    //this is also called on a fixed time rather than once per frame (50 times a sec by default)
    //handle movement
    void FixedUpdate()
    {
        //using the vars stored in movement to move the player
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
