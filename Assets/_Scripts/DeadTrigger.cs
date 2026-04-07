using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadTrigger : MonoBehaviour
{
    [SerializeField] private PlayerDeath playerDeath;

    private MoveCube player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject.GetComponent<MoveCube>();
        if (player != null )
        {
            playerDeath.DeathTrigger();
            Debug.Log(collision.name);

        }    
    }
}
