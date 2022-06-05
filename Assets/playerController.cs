using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerController : MonoBehaviour
{
    public LayerMask layerMask;

    public float moveSpeed;
    public float jumpForce;
    public bool onGround;



    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    public float horizontal = 0f;
    public bool hit;
    public bool place;

    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Ground"))
            onGround = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Ground"))
            onGround = false;
    }

    //void Update()
    //{
    //    if (joystick.Horizontal >= 2f)
    //    {
    //        horizontal = moveSpeed;
    //    }
    //    else if (joystick.Horizontal <= -.2f)
    //    {
    //        horizontal = -moveSpeed;
    //    }
    //    else
    //    {
    //        horizontal = 0f;
    //    }
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");
        float vertical = Input.GetAxis("Vertical");

        //animator.SetFloat("speed", Mathf.Abs(horizontal));

        Vector2 movement = new Vector2(horizontal * moveSpeed, rb.velocity.y);

        if (horizontal > 0)
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        else if (horizontal < 0)
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        if (vertical > 0.1f || jump > 0.1f)
        {
            //animator.SetBool("IsJumping", true);
            if (onGround)
                movement.y = jumpForce;
        }
        else
        {
            //animator.SetBool("IsJumping", false);
        }

        rb.velocity = movement;
    }
}
