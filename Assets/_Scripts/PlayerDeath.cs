using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private MoveCube moveCube;
    [SerializeField] private TilemapRenderer map;
    [SerializeField] private BoxCollider2D playerCol2D;
    [SerializeField] private List<SpriteRenderer> spikes;

    private bool isPunched;
    private void Start()
    {
        foreach (SpriteRenderer spike in spikes)
        {
            spike.enabled = true;
        }
        playerCol2D.enabled = true;
        map.enabled = true;
        isPunched = false;
    }

    public void DeathTrigger()
    {
        if(!isPunched)
        {
            StartCoroutine(Punch());
        }
        
    }
    private IEnumerator Punch()
    {
        
        moveCube.canMove = false;
        moveCube.GetComponent<Rigidbody2D>().AddForce(new Vector2(-15, 15), ForceMode2D.Impulse);
        map.enabled = false;
        playerCol2D.enabled = false;
        isPunched = true;
        foreach (SpriteRenderer spike in spikes)
        {
            spike.enabled = false;
        }
        yield return new WaitForSecondsRealtime(1.55f);

        moveCube.canMove = true;
        SceneManager.LoadScene(0);
    }
}
