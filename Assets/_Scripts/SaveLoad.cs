using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private List<Transform> checkpoints = new List<Transform>();
    [SerializeField] private int curPoint;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Checkpoint"))
        {
            curPoint = PlayerPrefs.GetInt("Checkpoint");
        }
        player.position = checkpoints[curPoint].position;
    }
    public void ChangeCheckpoint(int newCheckpoint)
    {
        curPoint = newCheckpoint;
        player.position = checkpoints[curPoint].position;
    }
    private void OnDestroy()
    {
        PlayerPrefs.SetInt("Checkpoint", curPoint);
        PlayerPrefs.Save();
    }
}


