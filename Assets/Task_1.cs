
using UnityEngine;
using System;
using Random = System.Random;

public class Task_1 : MonoBehaviour
{

    private void Start()
    {
        int[] array = SetArray(21);
        SetSum(array);
        WriteArray(array);
    }

    private int[] SetArray(int length)
    {
        int[] array = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(3, 59);
        }
        return array;
    }

    private int[] SetSum(int[] array)
    {
        int sum = 0;

        for (int i = 7; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }

        Debug.Log($"—умма чисел: {sum}");

        return array;
    }

    private void WriteArray(int[] array)
    {
        foreach (int elemnt in array)
        {
            Debug.Log($"Ёлементы массива: {elemnt}");
        }
    }
}

