using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float x_direction;
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PositionUpdate();
        InputHandler();
        Flip();
    }

    private void InputHandler()
    {
        x_direction = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        Vector2 jumpVelocity = new Vector2();
        jumpVelocity.y = 10;
        jumpVelocity.x = rb.velocity.x;

        rb.velocity = jumpVelocity;
    }

    public void Flip()
    {
        if (x_direction < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (x_direction > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    private void PositionUpdate()
    {
        transform.position += new Vector3(x_direction, 0, 0) * speed * Time.deltaTime;
    }
}
