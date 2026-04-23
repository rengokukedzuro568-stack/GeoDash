using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private float gravity = -25;
    [SerializeField] private float speed = 5;
    [SerializeField] private float jump = 10;
    [SerializeField] private LayerMask layerMask;
    private int direction = 1;

    public bool canMove = true;

    private bool isGround = true;
    private Rigidbody2D rgb;

    public void Revers()
    {
        direction *= -1;
    }

    void Start()
    {
        Physics2D.gravity = new Vector2(0, gravity);
        rgb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = false;
    }

    void Update()
    {
        if (canMove)
        {
            rgb.velocity = new Vector2(speed * direction, rgb.velocity.y);
            if (rgb.velocity.y < -10)
            {
                rgb.velocity = new Vector2(rgb.velocity.x, -10);
            }
            

        }
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.65f, layerMask);
        if (Input.GetKeyDown(KeyCode.Space) && hit.distance > 0)
        {
            Debug.Log("ping");
            rgb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }
}