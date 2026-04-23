using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public void ButtonStart()
    {
        player.SetActive(true);
        gameObject.SetActive(false);
    }
}
