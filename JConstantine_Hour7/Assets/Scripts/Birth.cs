using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Birth : MonoBehaviour
{
    int birthMonth = 4;
    int birthDay = 17;

    // Start is called before the first frame update
    void Start()
    {
        for (int month = 1; month <= birthMonth; month++)
        {
            if (month == birthMonth)
            {
                print("It's Your Birthday!");

                for (int day = 1; day <= birthDay; day++)
                {
                    if (day == birthDay)
                    {
                        print("It's Your Birthday!");
                    }
                    else
                    {
                        print(day);
                    }
                }
            }
            else
            {
                print(month);
            }
            }
        }
    }