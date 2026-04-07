using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Portal : MonoBehaviour
{
    [SerializeField] private float jumpBoost = 20f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private PortalType portalType;
    [SerializeField] private Transform portalDestination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MoveCube player = collision.GetComponent<MoveCube>();

        if (player != null)
        {
            switch (portalType)
            {
                case PortalType.jump:
                    {
                        rb.velocity = new Vector2(rb.velocity.x, 0);
                        rb.AddForce(Vector2.up * jumpBoost, ForceMode2D.Impulse);
                        break;
                    }
                case PortalType.teleport:
                    {
                        player.transform.position = portalDestination.position;
                        break;
                    }

                default:
                    break;
            }

           
        }
    }

    public enum PortalType
    {
        jump = 0,
        teleport = 1
    }
}

