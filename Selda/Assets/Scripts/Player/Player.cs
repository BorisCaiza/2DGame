using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad = 3;
    private Animator anim;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }


    private void FixedUpdate()
    {
       movimiento();
    }


    private void movimiento()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal, vertical) * velocidad;
        anim.SetFloat("Camina", Mathf.Abs(rb.velocity.magnitude));

        if (horizontal > 0)
        {
            _spriteRenderer.flipX = false;
        }
        else if (horizontal < 0 )
        {
            _spriteRenderer.flipX = true;
        }
    }
}
