using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    float birthMonth = 4f;
    float birthDay = 17
    float maxMonth = 13
    float maxDay = 32
        int currentMonth = 1
        int currentDay = 1

    // Start is called before the first frame update
    void Start()
    {
     for (int currentMonth = 1; currentMonth < birthMonth; currentMonth++)
     for (int currentDay = 1; currentDay < birthDay; currentDay++)
        {
            if (currentMonth == birthMonth; currentDay == birthDay)
            {
                print("It's your Birthday")
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

