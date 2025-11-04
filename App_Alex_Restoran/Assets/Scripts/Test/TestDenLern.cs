using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestDenLern : MonoBehaviour
{
    
    string d = "sdgewtWFAgsGqwrqwrFASFJBVUVRUQBRbqyirburwbiywBVIYFGIYBFIYBGFISENBg";

    
    void Update()
    {
        int randomInt = UnityEngine.Random.Range(-100, 10000);

        if (Input.GetKey(KeyCode.Space))
        {
            RegrupArr(d);
            Console.WriteLine(randomInt);
        }
        
       
    }
    private void RegrupArr(string st)
    {
        char[] array = new char[d.Length];

        for (int i = 0; i < d.Length; i++)
        {
            array[i] = d[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] += char.ToLower(array[i]);

        }

        array[0] += char.ToUpper(array[0]);
        array[array.Length - 1] += char.ToUpper(array[array.Length - 1]);
        Console.WriteLine(array);

    }

}
