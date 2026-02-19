using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadTrigger : MonoBehaviour
{
    private MoveCube player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject.GetComponent<MoveCube>();
        if (player != null )
        {
            SceneManager.LoadScene(0);

        }    
    }
}
