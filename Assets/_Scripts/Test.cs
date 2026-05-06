using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int x = 3;

    private void Start()
    {
        // цикл: старт = 5, шаг = 3, до 20
        for (int i = 5; i < 20; i += 3)
        {
            Debug.Log(i);
        }
    }

    private int Sum(int y)
    {
        return x * y;
    }
}
