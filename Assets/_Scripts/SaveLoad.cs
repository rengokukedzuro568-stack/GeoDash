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
        player.position = checkpoints[curPoint].position;
    }
}
