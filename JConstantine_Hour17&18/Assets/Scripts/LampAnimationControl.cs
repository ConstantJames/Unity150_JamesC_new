using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampAnimationControl : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Color", Input.GetKey(KeyCode.A));
        anim.SetBool("Hover", Input.GetKey(KeyCode.W));
        anim.SetBool("Rotate", Input.GetKey(KeyCode.S));
        anim.SetBool("Scale", Input.GetKey(KeyCode.D));
    }
}
