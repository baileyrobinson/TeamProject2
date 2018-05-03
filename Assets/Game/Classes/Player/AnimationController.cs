using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    public AnimationClip attack;
    public AnimationClip walk;
    public AnimationClip idle;
    Animation anim;
    bool Attack = false;
    bool Walk = false;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            anim.clip = walk;
            anim.Play();
            Walk = true;
        }
        else
        {
            anim.clip = idle;
            anim.Play();
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            anim.clip = attack;
            anim.Play();
            Attack = true;
        }
    }
}
