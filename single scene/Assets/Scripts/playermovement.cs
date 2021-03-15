using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    [SerializeField] private float moveForce, maxSpeed, jumpForce;
    [SerializeField] private Collider2D groundCheck;
    [SerializeField] private LayerMask groundLayers;

    private float moveDir;
    private Rigidbody2D myRB;
    private bool canJump;
    private SpriteRenderer mySR;
    
    private Animator anim;
    
    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        mySR = GetComponentInChildren<SpriteRenderer>();
    }

    /*private void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(moveDir));
    }*/

    private void FixedUpdate()
    {
        if (moveDir > 0)
        {
            mySR.flipX = false;
        }
        if (moveDir < 0)
        {
            mySR.flipX = true;
            
        }
        var moveAxis = Vector2.right * moveDir;

        if (Mathf.Abs(myRB.velocity.x) < maxSpeed)
        {
            myRB.AddForce(moveAxis * moveForce, ForceMode2D.Force);
        }

        if (groundCheck.IsTouchingLayers(groundLayers))
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveDir = context.ReadValue<float>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (canJump && context.started)
        {
            myRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }

        if (context.canceled && myRB.velocity.y > 0)
        {
            myRB.velocity = new Vector2(myRB.velocity.x, 0f);
        }
    }
}
