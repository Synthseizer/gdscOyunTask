using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D cld;

    [SerializeField] private LayerMask jumpableGround;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cld = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * 7f,rb.velocity.y);
        if (Input.GetKeyDown("space") && Grounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, 14f);
        }
    }
    private bool Grounded()
    {
        return Physics2D.BoxCast(cld.bounds.center, cld.bounds.size, 0f, Vector2.down,0.1f,jumpableGround);
    }
}