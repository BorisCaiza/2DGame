using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumSpeed = 3;

    private Rigidbody2D rb2d;

    public SpriteRenderer spriteRenderer;

    public Animator animator;

    public AudioSource saltar;

    public bool left;
    public bool right;
    public bool jump;

// Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }



    public void Left()
    {
        left = true;
    }
    
    public void noLeft()
    {
        left = false;
    }
    
    public void Right()
    {
        right = true;
    }
    
    public void noRight()
    {
        right = false;
    }
    
    public void Jump()
    {
        jump = true;
    }
    
    public void noJump()
    {
        jump = false;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || right)
        {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        
        else if (Input.GetKey(KeyCode.A) || left)
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }

        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.SetBool("Run", false);
        }

        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumSpeed);
            saltar.Play();
            animator.SetBool("Run", false);
        }
        
        if (jump && CheckGround.isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumSpeed);
            saltar.Play();
            animator.SetBool("Run", false);
        }


        if (!CheckGround.isGrounded)
        {
            animator.SetBool("Jump",true);
            animator.SetBool("Run", false);
        }
        
        if (CheckGround.isGrounded)
        {
            animator.SetBool("Jump",false);
            
        }
    }
}
