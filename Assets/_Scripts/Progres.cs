using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progres : MonoBehaviour
{
    private bool[] isReach = new bool[4];                                                                                   

    public void SaveCheckpoint(int number)
    {
        isReach[number] = true;
        PlayerPrefs.SetInt("c" + number, 1);
    }

}

