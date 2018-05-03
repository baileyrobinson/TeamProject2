using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyAttack : MonoBehaviour {
	Animator _animator;
	GameObject _player;
	private bool _collidedWithPlayer;
	// Use this for initialization
	void Start () {
		_player = GameObject.FindGameObjectWithTag("Player");
		_animator = GetComponent < Animator > ();
		_animator.SetBool("Moving", true);
	}
	void OnTriggerEnter(Collider other)

    {
        if (other.gameObject == _player)
        {
			_animator.SetBool("Moving", false);
			_animator.Play("Attack1");
		}
        print("enter trigger with _player");
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == _player)
        {
            _collidedWithPlayer = true;
        }
        print("enter collided with _player");
    }
 
    //void OnCollisionExit(Collision other)
    //{
    //    if (other.gameObject == _player)
    //    {
    //        _collidedWithPlayer = false;
    //    }
    //    print("exit collided with _player");
    //}
 
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _player)
        {
			_animator.SetBool("Moving", true);
			_collidedWithPlayer = false;
		}
        print("exit trigger with _player");
    }
    void Attack()
    {
        if (_collidedWithPlayer == true)
        {
            print("player has been hit");
        }
    }
}

