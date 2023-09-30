using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LightBulbSwitchScript : MonoBehaviour
{

    Light lightComponent;

    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light> ();
        lightComponent.type = LightType.Point;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if(lightComponent.enabled ==true)
                lightComponent.enabled = false;
            else
                lightComponent.enabled = true;
        }
    }
}
