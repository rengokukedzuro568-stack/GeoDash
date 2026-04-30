using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Progres progres;
    [SerializeField] private int number;
        
    private MoveCube player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject.GetComponent<MoveCube>();
        if (player != null)
        {

        }
    }
}

