using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_3 : MonoBehaviour
{
    private void Start()
    {
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        SearchOnNumber(array, 76);
    }

    private int SearchOnNumber(int[] array, int number)
    {
        int index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                Debug.Log($"Номер первого вхождения числа: {i}");
                return i;
            }
        }

        Debug.Log($"Нет такого числа, индекс: {index}");
        return index;
    }
}
