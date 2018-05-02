using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMovement : MonoBehaviour
{
    
    public Transform Player;
    public int MoveSpeed = 10;
    public int MaxDist = 10; //distance to preform action
    public int MinDist = 5; //how close they aproach
    public int Range = 25; //detection range



    void Start()
    {

    }

    void Update()
    {
        Player = GameObject.FindWithTag("Player").transform;

        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) <= Range)
        {
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;



                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    //Here adjust distance for att animation
                }

            }
        }

    }
}