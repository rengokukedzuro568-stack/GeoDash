using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int x = 3;

    private void Start()
    {
        Debug.Log(Sum(2));
    }
    private int Sum(int y)
    {
        return x*y;
    }
}
