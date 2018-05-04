using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyAttack : MonoBehaviour {
	Animator _animator;
	GameObject _player;
	private bool _collidedWithPlayer;
	private PlayerHealth _hitPlayer;
	int damage = 10;
	// Use this for initialization
	void Start () {
		_hitPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
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
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == _player)
        {
            _collidedWithPlayer = true;
        }
        
    }
 
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _player)
        {
			_animator.SetBool("Moving", true);
			//_collidedWithPlayer = false;
			
		}
        
    }
    void Attack()
    {
        if (_collidedWithPlayer == true)
        {
            
			_hitPlayer.TakeDamage(damage);

		}
    }
}

