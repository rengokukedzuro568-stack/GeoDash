using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class WallDeath : MonoBehaviour
{
    [SerializeField] private MoveCube moveCube;
    [SerializeField] private TilemapRenderer map;
    [SerializeField] private BoxCollider2D col2D;

    private bool isPunched;
    private void Start()
    {
        col2D.enabled = true;
        map.enabled = true;
        isPunched = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetType() == typeof(TilemapCollider2D) && !isPunched)
            {
            StartCoroutine(Punch());
        }

    }
    private IEnumerator Punch() 
    { 
       
        moveCube.canMove = false;
        moveCube.GetComponent<Rigidbody2D>().AddForce(new Vector2 (-15, 15),ForceMode2D.Impulse);
        map.enabled = false;
        col2D.enabled = false;
        isPunched = true;   
        yield return new WaitForSecondsRealtime(1.55f);
       
        moveCube.canMove = true;
        SceneManager.LoadScene(0);
    }
}
