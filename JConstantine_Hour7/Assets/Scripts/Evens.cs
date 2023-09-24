using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class Evens : MonoBehaviour
{
    int theNumber = 102;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 22; i < theNumber; i++)
        {
            if (i % 2 == 0)
            {
            print("Even Number: " + i);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
