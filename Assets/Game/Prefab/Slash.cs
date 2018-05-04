using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour {
    Animator anim;
	GameObject _enemy;
	private PlayerWeapon1 _hitPlayer;
	int slash = Animator.StringToHash("Slash");


    void Start()
    {
		_hitPlayer = GameObject.FindGameObjectWithTag("Sword").GetComponent<PlayerWeapon1> ();
		anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger(slash);
			_hitPlayer.Attack();
		}
    }
}
