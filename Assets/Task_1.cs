
using UnityEngine;
using System;
using Random = System.Random;

public class Task_1 : MonoBehaviour
{

    private void Start()
    {
        Counting();
    }

    private void Counting()
    {
        int sum = 0;

        for (int i = 7; i < 22; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }

        Debug.Log($"Сумма четных чисел: {sum}");
    }
}

