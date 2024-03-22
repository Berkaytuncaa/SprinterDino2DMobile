using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    private Rigidbody2D _rb;
    public Animator animator;

    [SerializeField] private float jumpForce;

    private bool _isGrounded;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isGrounded)
        {
            Jump();
        }

        animator.SetBool("_isGrounded",_isGrounded);
    }

    private void Jump()
    {
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void Death()
    {
        Time.timeScale = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGrounded = true;
        }

        if (collision.gameObject.tag == "Spike")
        {
            // TODO: set death screen active here
            Death();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGrounded = false;
        }
    }
}
