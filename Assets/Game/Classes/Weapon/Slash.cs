using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour {
    Animator anim;
    int slash = Animator.StringToHash("Slash");


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger(slash);
        }
    }
}
