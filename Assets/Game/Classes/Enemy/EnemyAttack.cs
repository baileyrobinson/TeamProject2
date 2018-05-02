using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    int damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
    }
}
