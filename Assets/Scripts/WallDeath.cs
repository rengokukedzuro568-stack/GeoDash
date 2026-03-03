using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class WallDeath : MonoBehaviour
{
    [SerializeField] private MoveCube moveCube;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetType() == typeof(TilemapCollider2D))
            {
            StartCoroutine(Punch());
        }

    }
    private IEnumerator Punch() 
    { 
        moveCube.canMove = false;
        moveCube.GetComponent<Rigidbody2D>().AddForce(new Vector2 (-15, 15),ForceMode2D.Impulse);
        yield return new WaitForSecondsRealtime(1.55f);
        moveCube.canMove = true;
        SceneManager.LoadScene(0);
    }
}
