using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon1 : MonoBehaviour {
    int Level = PlayerInventory.WeaponLevel;
    float BaseDamage = 10;
    int damage = 1;
    EnemyHealth target;
	private EnemyHealth _hitPlayer;
	public float range; //attack distance

	void Start()
	{
		//_hitPlayer = GameObject.FindGameObjectWithTag("enemy").GetComponent<EnemyHealth>();

	}

	//void dealDamage()
	//   {
	//       if (PlayerInventory.WeaponLevel <= 9)
	//       {
	//           for (int i = 0; i <= Level; i++)
	//           {
	//               damage += BaseDamage;
	//           }
	//       }
	//       if (PlayerInventory.WeaponLevel >= 10)
	//       {
	//           damage += BaseDamage *= 15;
	//       }
	//       if (PlayerInventory.WeaponLevel >= 15)
	//       {
	//           damage += BaseDamage *= 30;
	//       }
	//   }
	void OnTriggerEnter(Collider other)
	{
		//dealDamage();
		target = other.GetComponentInParent<EnemyHealth>();
		target.TakeDamage(damage);
	}
	public void Attack()
	{
		print("ATACKING");
		//Ray straight out of the center of the camera
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, range) && hit.collider.isTrigger && hit.collider.GetComponent<EnemyHealth>() != null)
		{
			print("HELLOOOOO");
			//dealDamage();
			//Replace "Destructible" with the class name for your destructible object/enemy.  TakeDamage() should also check if health < 0, emit sounds, etc
			hit.collider.GetComponent<EnemyHealth>().TakeDamage(50);
		}
	}

}
