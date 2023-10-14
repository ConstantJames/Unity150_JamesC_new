using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcersizeTriggerScript : MonoBehaviour
{
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
        print("Entered the: " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print("Exited the: " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        print("Inside the: " + gameObject.name);
    }
}
