using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progres : MonoBehaviour
{
    private bool[] isReach = new bool[4];

    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            if (PlayerPrefs.HasKey("c" + i ))
            {
                isReach[i] = 1==PlayerPrefs.GetInt("c" + i);
            }
        }
           

        
    }

    public void SaveCheckpoint(int number)
    {
        isReach[number] = true;
        PlayerPrefs.SetInt("c" + number, 1);
    }


}

