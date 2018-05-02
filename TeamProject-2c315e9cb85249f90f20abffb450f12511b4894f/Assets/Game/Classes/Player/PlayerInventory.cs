using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
    static public float Materials = 0;
    static public float Money = 0;
    static public int WeaponLevel = 1;
    public Text gold;
    public Text material;
    public Text weaponlevel;

    void Update()
    {
        gold.text = "Gold: " + Money.ToString();
        material.text = "Materials: " + Materials.ToString();
        weaponlevel.text = "Weapon: " + WeaponLevel.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Gold")
        {
            Money += 100;
            Destroy(collision.gameObject);
           // Destroy(collision.gameObject);
        }

        if (collision.transform.tag == "Material")
        {
            Materials += 100;
            Destroy(collision.gameObject);
            //Destroy(collision.gameObject);
        }
    }
}

