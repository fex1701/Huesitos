using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [SerializeField] private TMP_Text TextScore;
    [SerializeField] private int Score = 0;
    [SerializeField] private Animator animator;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // || &&
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGround)


        {
            _rb2d.AddForce(Vector2.up * fuerzaSalto);


        }


        float move = Input.GetAxis("Horizontal");

        animator.SetFloat("Movement", Mathf.Abs(move));

        animator.SetFloat("VelocidadY", _rb2d.linearVelocity.y);


        if (move > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (move < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }

    private void FixedUpdate()
    {

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        _rb2d.linearVelocity = new Vector2(movimientoHorizontal * moveSpeed, _rb2d.linearVelocity.y);


        animator.SetBool("isGround", isGround);



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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Score+=1;
            TextScore.text = "Puntaje: " + Score;


        }
    }

}