using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;
    [SerializeField] private float fuerzaSalto = 125f;
    [SerializeField] private bool isGround;
    [SerializeField] private float moveSpeed = 5f;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // || &&
    void  Update()
    {
      
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && isGround)
        {
            _rb2d.AddForce(Vector2.up * fuerzaSalto);
        }



        float movimientoHorizontal = Input.GetAxis("Horizontal");
        _rb2d.linearVelocity = new Vector2(movimientoHorizontal * moveSpeed, _rb2d.linearVelocity.y);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }

    }
}
