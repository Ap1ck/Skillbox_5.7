using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_2 : MonoBehaviour
{
    private void Start()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        SetSum(array);
    }

    private int[] SetSum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }

        Debug.Log($"Сумма элементов: {sum}");

        return array;
    }

}
