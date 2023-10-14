using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BounceCountScript : MonoBehaviour
{
   int X = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        print("Bounce Counter: " + ( X + 1));
    }

    void OnTriggerExit(Collider other)
    {
        X++;
    }
}
