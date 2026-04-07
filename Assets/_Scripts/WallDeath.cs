using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class WallDeath : MonoBehaviour
{
    [SerializeField] private PlayerDeath playerDeath;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetType() == typeof(TilemapCollider2D) )
            {
            
            playerDeath.DeathTrigger();
        }

    }
    
}

