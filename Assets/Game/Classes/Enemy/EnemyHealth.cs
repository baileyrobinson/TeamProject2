using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private EnemyManager _spawnManager;

    public int startingHealth = 100;// The amount of health the player starts the game with.
    static public int currentHealth;
    public GameObject enemy;
	public GameObject sword;
	public GameObject Gold;
    public Transform GoldSpawn;
    public GameObject Material;
    public Transform MaterialSpawn;


    public float dropRate = .70f; //70% drop chance 
    

    //     // Clone the objects that are "in" the box.
    //     foreach (GameObject item in items)
    //     {
    //         if (item != null)
    //         {
    //             // Add code here to change the position slightly
    //             // so the items are scattered a little bit.
    //             Instantiate(item, position, Quaternion.identity);

    // Use this for initialization
    void Start()
    {
        Vector3 position = transform.position;

        _spawnManager = GameObject.FindGameObjectWithTag("spawnManager").GetComponent<EnemyManager>();

        currentHealth = startingHealth;

        //Death();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int value)
    {
		print("TAKING DAMAGE");
        currentHealth -= value;
        if (currentHealth <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        _spawnManager.enemyDefeated();
        

        if (Random.Range(0f, 1f) <= dropRate)
        {
            Instantiate(Gold, transform.position, GoldSpawn.rotation);
            if (Random.Range(0f, 1f) <= dropRate)
            {
                
                Instantiate(Material, transform.position, MaterialSpawn.rotation);

            }
        }
        GameObject.Destroy(enemy);
    }
	//void OnTriggerEnter(Collider other)

	//{
	//	if (other.gameObject == sword)
	//	{
	//		TakeDamage(50);
	//	}

	//}
}
